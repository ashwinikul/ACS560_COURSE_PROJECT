
//  Server Side Code V1.3
//  Created By Ashwini 





package main
import (
	"database/sql"
	"github.com/encryption"
	_ "github.com/mattn/go-sqlite3"
)
// SQLite database driver


import (
 "net"
 "fmt"
 "bufio"
 "strings" 
 "log"
 "time"
 "strconv"
)

// defining public variable 
var db *sql.DB


// It will  store obj value of userlogin table
type userlogin struct {
userid int
user_name string
user_type string
u_password string
createdBy  string
UpdatedBy string
Modifieddate time.Time

}

type useradmin struct {
userid int
user_name string
user_type string
Cnt string
Min_Sla  string
Max_Sla string


}
 
// It will store obj value of userdetails table
type userdetails struct {
userid int
user_Full_name string
gender string
Location string
Contact  string
SecurityQus string
SecurityAns string
createdBy  string
UpdatedBy string
Modifieddate time.Time
 
}


// It will store obj value of adds table
type adds  struct{
addid int 
add_name string
userid int
add_details string
block int
createdBy  string
UpdatedBy string
Modifieddate time.Time
username string
}

// It will store obj value of comments table
type comments  struct{
commentid int
addid int 
userid int
comment string
block int
createdBy  string
UpdatedBy string
Modifieddate time.Time
username string

}

// It will store obj value of add_security table
type  add_security struct {
secid int
a_type string
addid string 
commentid string
block string
userid int
createdBy  string
UpdatedBy string
Modifieddate time.Time
data_text string
}


// For Multiple client handling
func goclienthandle(conn net.Conn) {
 
var x string
var username string
var usertype string
var pass string
var P userlogin
var PD userdetails
var data_received string=""


//Database Connection 	
db, err := sql.Open("sqlite3", "/home/ashwini/work/DB2")
if err != nil { panic(err) }
if db == nil { panic("db nil") }
	
fmt.Println("Database Connection Established...")
	
	
// data receive from cient
		
message, _ := bufio.NewReader(conn).ReadString('\n')
data_received=string(message)
data_received=strings.TrimSpace(data_received)
fmt.Println(" Register data Received:", data_received)
result := strings.Split(data_received, "|") // each elements from client data are seperated by | character.
x=string(result[0]) // result[0] will give the which operation event have send the data
x=strings.TrimSpace(x) // will remove spaces
		
switch x {
		
		
		case "Login": 
						// this block is designed for login operation
						
						fmt.Println("Operation Received:", result[0])
						fmt.Println("Username Received:", result[1])
						username=string(result[1])
						username=strings.TrimSpace(username)
						
						pass=string(result[2])
						pass=strings.TrimSpace(pass)
						
						//getting information from DB for received user string
						rows, err := db.Query("select userid, user_name,user_type,u_password,createdBy,UpdatedBy, Modifieddate from userlogin where user_name = ?",username )
						if err != nil {
										log.Fatal(err)
									  }
										defer rows.Close()
						for rows.Next() {
											err := rows.Scan(&P.userid, &P.user_name,&P.user_type,&P.u_password,&P.createdBy,&P.UpdatedBy, &P.Modifieddate)
											if err != nil {
															log.Fatal(err)
														  }
											fmt.Print(P.userid)
										}
						pass_wd:=encryption.GetPasswd(P.u_password)				
						if(username == P.user_name && pass == pass_wd) {
																				fmt.Println("Success")
																				conn.Write([]byte(P.user_type + "\n"))  // data sent to client
																			} else {
																						fmt.Println("Failed")
																						conn.Write([]byte("Failed" + "\n"))  // data sent to client
																					}

					  
		case "Register", "SMRegister","Profile_Change": 
		
		
						// this block is designed for Register operation
						
		
						// determining usertype
						
						if x=="Register" {
						usertype="enduser"
						} else if x=="Profile_Change" {
						usertype="enduser"
						} else if x=="SMRegister" {
						usertype="secmgr"
						}
						P.user_name=result[1]
						
						
						// checking whether entered username from new user is already exist or not
						rows, err := db.Query("select userid, user_name from userlogin where user_name = ?",P.user_name )
						i:=0
						if err != nil {
										log.Fatal(err)
									  }
										defer rows.Close()
						for rows.Next() {
											err := rows.Scan(&P.userid, &P.user_name)
											if err != nil {
															log.Fatal(err)
														  }
														  i++
											fmt.Print(P.userid)
										}
						if i!=0 && x!="Profile_Change" {
						conn.Write([]byte("User already present" + "\n"))
						} else {
						
						
						// P is object of Userlogin type										
						P.user_name=result[1]
						P.user_type=usertype
						P.u_password=result[2]
						P.createdBy=result[1]
						P.UpdatedBy=result[1]
						
						P.u_password=encryption.GetCode(P.u_password)
						
						// Inserting data in Userlogin Table
						if x!="Profile_Change" {
						
						DCL, err := db.Exec("Begin Transaction;")
						
						resultset, err := db.Exec("Insert into userLogin (user_name, user_type, u_password, createdBy, UpdatedBy, Modifieddate) values($1,$2,$3,$4,$5, datetime('now'))",P.user_name,P.user_type,P.u_password,P.createdBy,P.UpdatedBy)
						if err != nil {
										log.Fatal(err)
									  }
										//defer resultset.Close()
								
										fmt.Println(" ID insert : ",resultset)
						DCL, err = db.Exec("commit;")			
						fmt.Println(" DCL : ",DCL)						
						
						}
						//getting user_id for newly inserted user
						rows, err := db.Query("select userid, user_name from userlogin where user_name = ?",P.user_name )
						
						if err != nil {
										log.Fatal(err)
									  }
										defer rows.Close()
						for rows.Next() {
											err := rows.Scan(&P.userid, &P.user_name)
											if err != nil {
															log.Fatal(err)
														  }
														  
											fmt.Print(P.userid)
										}
										
										
						// PD is object of UserDetails type	
						PD.userid=P.userid
						PD.user_Full_name = result[3]
						PD.gender = result[4]
						PD.Location = result[5]
						PD.Contact = result[6]
						PD.SecurityQus = result[7]
						PD.SecurityAns = result[8]
						PD.createdBy  = result[1]
						PD.UpdatedBy =result[1]
						
						if x=="Profile_Change" {
						
						DCL, err := db.Exec("Begin Transaction;")
						resultset2, err := db.Exec("UPDATE userDetails SET Location=$1, Contact=$2, SecurityQus=$3, SecurityAns=$4, UpdatedBy=$5, Modifieddate=datetime('now') WHERE userid=$6 ;",PD.Location, PD.Contact , PD.SecurityQus, PD.SecurityAns , PD.UpdatedBy,PD.userid )
						if err != nil {
										log.Fatal(err)
									  }
										//defer resultset.Close()
										fmt.Println(" ID insert : ",resultset2)
						DCL, err = db.Exec("commit;")	
						
						fmt.Println(" DCL : ",DCL)
						conn.Write([]byte("Success" + "\n"))
						
						
						} else {
						// Inserting data in UserDetails table
						DCL, err := db.Exec("Begin Transaction;")
						resultset2, err := db.Exec("Insert into userDetails (userid , user_Full_name , gender, Location, Contact , SecurityQus, SecurityAns ,createdBy, UpdatedBy, Modifieddate) values($1,$2,$3,$4,$5,$6,$7,$8, $9, datetime('now'))",PD.userid , PD.user_Full_name , PD.gender, PD.Location, PD.Contact , PD.SecurityQus, PD.SecurityAns ,PD.createdBy, PD.UpdatedBy)
						if err != nil {
										log.Fatal(err)
									  }
										//defer resultset.Close()
										fmt.Println(" ID insert : ",resultset2)
						DCL, err = db.Exec("commit;")	
						
						fmt.Println(" DCL : ",DCL)
						conn.Write([]byte("Success" + "\n"))
						}
						}

						
					
						
		case "Profile": // Sending profile data to user.			
						 
						
						username=""
						username=result[1]
						
						rows, err := db.Query("select u.userid , user_Full_name , gender, Location, Contact , SecurityQus, SecurityAns, l.u_password  from userDetails u inner join userlogin l on u.userid=l.userid where l.user_name = ?",username )
						
						if err != nil {
										log.Fatal(err)
									  }
										defer rows.Close()
						for rows.Next() {
											err := rows.Scan(&PD.userid , &PD.user_Full_name , &PD.gender, &PD.Location, &PD.Contact , &PD.SecurityQus, &PD.SecurityAns,&P.u_password)
											if err != nil {
															log.Fatal(err)
														  }
														  
											fmt.Print(PD.user_Full_name)
										}
						var profileData string
						profileData=username + "|" + strconv.Itoa(PD.userid) + "|" + PD.user_Full_name + "|" + PD.gender + "|" + PD.Location + "|" + PD.Contact + "|" + PD.SecurityQus + "|" + PD.SecurityAns + "|" + encryption.GetPasswd(P.u_password)
						fmt.Print(profileData)
						conn.Write([]byte(profileData + "\n"))
						
						
		case "SM_Get_Data": // For getting Security manager work data from database and send it to Security manager Home			
						 
						
						username=""
						username=result[1]
						
						
						 bks := make([]*add_security, 0)
						
						rows, err := db.Query("select U.userid, U.user_name, S.Type, IFNULL(S.addid,''), IFNULL(S.commentid,''), IFNULL(S.block,'') , S.Modifieddate ,CASE WHEN S.type='add' then A.add_details WHEN S.type ='comment' then C.comment END DATA_text from userlogin U INNER JOIN add_security S on U.userid=S.userid LEFT JOIN adds A on S.addid=A.addid LEFT JOIN Comments C on s.commentid =C.commentid where U.user_name=$1 and S.Block is NULL and (S.addid IS NOT NULL OR S.Commentid IS NOT NULL) order by S.Modifieddate ASC",username )
						i:=0
						if err != nil {
										log.Fatal(err)
									  }
										defer rows.Close()
						for rows.Next() {
											bk := new(add_security)
						
											err := rows.Scan(&bk.userid , &P.user_name , &bk.a_type, &bk.addid ,&bk.commentid, &bk.block, &bk.Modifieddate, &bk.data_text)
											if err != nil {
															log.Fatal(err)
														  }
														  i++
											fmt.Println(i)
											bks = append(bks, bk)
										}
						var profileData string
						var count string
						count=strconv.Itoa(i)
						fmt.Println(count)
						conn.Write([]byte(count + "\n"))
						 for _, bk := range bks{
						profileData=bk.a_type + "|" + string(bk.addid) + "|" + string(bk.commentid) + "|" + bk.data_text + "|" + strconv.Itoa(bk.userid) + "|" + bk.block 
						fmt.Println(profileData)
						conn.Write([]byte(profileData + "\n"))
						}
						
		
		
		case "SM_ALLOW" : // security manager role: allow or decline comments and adds 
						username=""
						username=result[1]
						result[2]=strings.TrimSpace(result[2])
						result[3]=strings.TrimSpace(result[3])
						result[4]=strings.TrimSpace(result[4])
						result[5]=strings.TrimSpace(result[5])

						
						// Remark : Need to minimize update query code
						var query string
						//query="UPDATE add_security SET block=1 , Modifieddate=datetime('now') where addid in ("+result[2]+") or commentid in ("+result[2]+")"
						fmt.Println(query)
						DCL, err := db.Exec("Begin Transaction;")
						query="UPDATE add_security SET block=1 , Modifieddate=datetime('now') where addid in ("+result[2]+") or commentid in ("+result[3]+")"
						resultset2, err := db.Exec(query)
						if err != nil {
										log.Fatal(err)
									  }
										//defer resultset.Close()
										fmt.Println(" ID insert : ",resultset2)
										
					    query="UPDATE add_security SET block=2 , Modifieddate=datetime('now') where addid in ("+result[4]+") or commentid in ("+result[5]+")"
						resultset2, err = db.Exec(query)
						if err != nil {
										log.Fatal(err)
									  }
										//defer resultset.Close()
										fmt.Println(" ID insert : ",resultset2)		

						query="UPDATE adds SET block=1 , Modifieddate=datetime('now') where addid in ("+result[2]+")"
						resultset2, err = db.Exec(query)
						if err != nil {
										log.Fatal(err)
									  }
										//defer resultset.Close()
										fmt.Println(" ID insert : ",resultset2)
										
						query="UPDATE adds SET block=2 , Modifieddate=datetime('now') where addid in ("+result[4]+")"
						resultset2, err = db.Exec(query)
						if err != nil {
										log.Fatal(err)
									  }
										//defer resultset.Close()
										fmt.Println(" ID insert : ",resultset2)				

						query="UPDATE comments SET block=1 , Modifieddate=datetime('now') where commentid in ("+result[3]+")"
						resultset2, err = db.Exec(query)
						if err != nil {
										log.Fatal(err)
									  }
										//defer resultset.Close()
										fmt.Println(" ID insert : ",resultset2)		
										
						query="UPDATE comments SET block=2 , Modifieddate=datetime('now') where commentid in ("+result[5]+")"
						resultset2, err = db.Exec(query)
						if err != nil {
										log.Fatal(err)
									  }
										//defer resultset.Close()
										fmt.Println(" ID insert : ",resultset2)											
						

										
						DCL, err = db.Exec("commit;")	
						
						fmt.Println(" DCL : ",DCL)
						conn.Write([]byte("Success" + "\n"))
						

							
		

		
		case "Admin_Get_Data" : // getting data from database for admin work and sending it to admin home
								username=""
						username=result[1]
						//username=strings.TrimSpace(username)
						
						recs := make([]*useradmin, 0)
						
						
						
						rows, err := db.Query("select A.userid, A.user_name, A.user_type, count(S.userid) Count, ifnull(min(CAST( (julianday('now') - julianday(S.Modifieddate)) * 24 * 60 As Integer)),0) min_req_SLA, ifnull(Max(CAST( (julianday('now') - julianday(S.Modifieddate)) * 24 * 60 As Integer)),0) max_req_SLA FROM userLogin A LEFT JOIN add_security S ON A.userid=S.userid and S.block is NULL and (S.addid is not null or S.commentid is not null) where A.user_type in('secmgr','secmgrhalt') group by  A.userid, A.user_name, A.user_type")
						i:=0
						if err != nil {
										log.Fatal(err)
									  }
										defer rows.Close()
						for rows.Next() {
											rec := new(useradmin)
						
											err := rows.Scan(&rec.userid , &rec.user_name , &rec.user_type, &rec.Cnt,&rec.Min_Sla, &rec.Max_Sla)
											if err != nil {
															log.Fatal(err)
														  }
														  i++
											fmt.Println(i)
											recs = append(recs, rec)
										}
						var profileData string
						var count string
						count=strconv.Itoa(i)
						fmt.Println(count)
						conn.Write([]byte(count + "\n"))
						 for _, rec := range recs{
						profileData=strconv.Itoa(rec.userid) + "|" + rec.user_name + "|" + rec.user_type + "|" + string(rec.Cnt) + "|" + string(rec.Min_Sla) + "|" + string(rec.Max_Sla)
						fmt.Println(profileData)
						conn.Write([]byte(profileData + "\n"))
						}
		
		
		case "Admin_Delete_SM":     // delete security manager
									username=""
									username=result[1]
									username=strings.TrimSpace(username)
									SM_NAme:=result[2]
									SM_NAme=strings.TrimSpace(SM_NAme)
									DCL, err := db.Exec("Begin Transaction;")
									
										
									resultset2, err := db.Exec("UPDATE userLogin SET user_type='secmgrdelete' , UpdatedBy=$1, Modifieddate=datetime('now') where user_name=$2",username,SM_NAme)
									if err != nil {
										log.Fatal(err)
									  }
										//defer resultset.Close()
										fmt.Println(" ID insert : ",resultset2)
									DCL, err = db.Exec("commit;")
									fmt.Println(" DCL : ",DCL)
									conn.Write([]byte("Success" + "\n"))
		
		case "Admin_Sm_Halt": 		// Setting pause flag on Security manager to restrain from work
		
									username=""
									username=result[1]
									username=strings.TrimSpace(username)
									result[2]=strings.TrimSpace(result[2])
									result[3]=strings.TrimSpace(result[3])
									username="'"+username+"'"
									DCL, err := db.Exec("Begin Transaction;")
									
									
									query :="UPDATE userLogin SET user_type='secmgrhalt' , UpdatedBy=$1, Modifieddate=datetime('now') where userid in ("+result[3]+")"
									
									resultset2, err := db.Exec(query,username)
									if err != nil {
										log.Fatal(err)
									  }
										//defer resultset.Close()
										fmt.Println(" ID insert : ",resultset2)
										
									query="UPDATE userLogin SET user_type='secmgr' , UpdatedBy=$1, Modifieddate=datetime('now') where userid in ("+result[2]+")"
									
									resultset2, err = db.Exec(query,username)
									if err != nil {
										log.Fatal(err)
									  }
										//defer resultset.Close()
										fmt.Println(" ID insert : ",resultset2)	
									DCL, err = db.Exec("commit;")
									fmt.Println(" DCL : ",DCL)
									conn.Write([]byte("Success" + "\n"))
									
		case "My_adds","Search_Add","Get_Add_Details" :
		
						var query string 
						username=""
						username=result[1]
						//userid:=result[2]
						keyword:=result[2]
						fmt.Println(keyword)
						//fmt.Println(keyword)
						//username=strings.TrimSpace(username)
						i:=0
						bks := make([]*adds, 0)
						recs := make([]*comments, 0)
						if result[0]=="My_adds" {
						query = "select IFNULL(U.userid,''),IFNULL(U.user_name,''), IFNULL(A.addid,''), IFNULL(A.add_name,''), IFNULL(A.add_details,''), A.modifieddate from userlogin U Inner join Adds A on U.userid=A.userid where A.block =1 and U.user_name=$1 order by A.modifieddate desc"
						//rows, err := db.Query("select IFNULL(U.userid,''),IFNULL(U.username,''), IFNULL(A.addid,''), IFNULL(A.addname,''), IFNULL(A.add_details,''), IFNULL(A.modifieddate,'') from userlogin U Inner join Adds A on U.userid=A.userid where A.block =1 and U.userid=$1 order by A.modifieddate desc",userid )
						
						// bks := make([]*adds, 0)
						} else if result[0]=="Search_Add" {
						query ="select IFNULL(U.userid,''),IFNULL(U.user_name,''), IFNULL(A.addid,''), IFNULL(A.add_name,''),IFNULL(A.add_details,''), A.modifieddate from userlogin U Inner join Adds A on U.userid=A.userid where A.block =1 and A.add_name like '%"+keyword+"%' order by A.modifieddate desc"
						//rows, err := db.Query("select IFNULL(U.userid,''),IFNULL(U.username,''), IFNULL(A.addid,''), IFNULL(A.addname,''),IFNULL(A.add_details,''), IFNULL(A.modifieddate,'') from userlogin U Inner join Adds A on U.userid=A.userid where A.block =1 and U.add_name like '%$1%' order by A.modifieddate desc",keyword )
						
						 //bks := make([]*adds, 0)
						} else if result[0]=="Get_Add_Details" {
						
						query="select IFNULL(U.userid,''),IFNULL(U.user_name,''), IFNULL(A.addid,''),IFNULL(C.comment,''), C.modifieddate from adds A inner join comments C  ON A.addid=c.addid Inner join userlogin U on C.userid=U.userid where A.addid="+keyword+" and C.block =1  order by C.modifieddate desc"
						
						//rows, err := db.Query("select IFNULL(U.userid,''),IFNULL(U.username,''), IFNULL(A.addid,''),IFNULL(C.comment,''), IFNULL(C.modifieddate,'') from adds A inner join comments C  ON A.addid=c.addid Inner join userlogin U on C.userid=U.userid where A.addid=$1 and C.block =1  order by C.modifieddate desc",keyword )
						
						//bks = make([]*comments, 0)
						
						}
						
						rows, err := db.Query(query,username)
						if err != nil {
										log.Fatal(err)
									  }
										defer rows.Close()
						for rows.Next() {
											if result[0]=="My_adds" || result[0]=="Search_Add" {
																		bk := new(adds)
																		err := rows.Scan(&bk.userid , &bk.username ,&bk.addid ,&bk.add_name,&bk.add_details, &bk.Modifieddate)
																		if err != nil {
																						log.Fatal(err)
																					}
																		bks = append(bks, bk)
											}  else if result[0]=="Get_Add_Details" {
																		rec:= new(comments)
																		err := rows.Scan(&rec.userid , &rec.username ,&rec.addid ,&rec.comment, &rec.Modifieddate)
																		if err != nil {
																						log.Fatal(err)
																						}
																		recs = append(recs, rec)
						
											}
											
											
														  i++
											fmt.Println(i)
											
										}
						var profileData string
						var count string
						count=strconv.Itoa(i)
						fmt.Println(count)
						conn.Write([]byte(count + "\n"))
						if result[0]=="My_adds" || result[0]=="Search_Add" {
						for _, bk := range bks{
						profileData=strconv.Itoa(bk.userid) + "|" +bk.username+"|"+ strconv.Itoa(bk.addid) + "|" + bk.add_name + "|" + bk.add_details + "|" + bk.Modifieddate.String()
						fmt.Println(profileData)
						conn.Write([]byte(profileData + "\n"))
						}
						} else if result[0]=="Get_Add_Details" {
						for _, rec := range recs{
						profileData=strconv.Itoa(rec.userid) + "|" +rec.username+"|"+ strconv.Itoa(rec.addid) + "|" + rec.comment + "|" + rec.Modifieddate.String()
						fmt.Println(profileData)
						conn.Write([]byte(profileData + "\n"))
						}
						}
		

		case "Add_Insert":
						username=""
						username=result[1]
						addname:= result[2]
						adddetails :=result[3]
						
						
						DCL, err := db.Exec("Begin Transaction;")
						resultset2, err := db.Exec("insert into adds (add_name,userid,add_details,block,createdBy,UpdatedBy,Modifieddate) values ( $1,(select userid from userlogin where user_name=$2 limit 1),$3,NULL,$2,$2,datetime('now'))",addname,username,adddetails)
						if err != nil {
										log.Fatal(err)
									  }
										//defer resultset.Close()
										fmt.Println(" ID insert : ",resultset2)
						DCL, err = db.Exec("commit;")	
						
						fmt.Println(" DCL : ",DCL)
						conn.Write([]byte("Success" + "\n"))
						
		
		case "Comment_Insert":	
						
						username=""
						username=result[1]
						addid:=result[2]
						comment_detail := result[3]
						
						
						
						DCL, err := db.Exec("Begin Transaction;")
						resultset2, err := db.Exec("insert into comments (addid,userid,comment,block,createdBy,UpdatedBy,Modifieddate) values ($1,(select userid from userlogin where user_name=$2 limit 1),$3,NULL,$2,$2,datetime('now'))",addid,username,comment_detail)
						if err != nil {
										log.Fatal(err)
									  }
										//defer resultset.Close()
										fmt.Println(" ID insert : ",resultset2)
						DCL, err = db.Exec("commit;")	
						
						fmt.Println(" DCL : ",DCL)
						conn.Write([]byte("Success" + "\n"))

				
		case "Get_Sec_Qus": 
						username=""
						username=result[1]
						i:=0
						var exist_username string
						rows, err := db.Query("select U.user_name,D.SecurityQus, D.SecurityAns, U.u_password from userlogin U inner join userDetails D On U.userid=D.userid where U.user_name = ?",username )
						if err != nil {
										log.Fatal(err)
									  }
										defer rows.Close()
						for rows.Next() {
											err := rows.Scan( &P.user_name,&PD.SecurityQus,&PD.SecurityAns,&P.u_password)
											if err != nil {
															log.Fatal(err)
														  }
														  i++
											fmt.Print(P.userid)
										}
										if i==0 {
										exist_username="Username Not Exists"
										} else {
										exist_username = P.user_name+"|"+PD.SecurityQus+"|"+PD.SecurityAns+"|"+encryption.GetPasswd(P.u_password)
										 
										}
										
										conn.Write([]byte(exist_username + "\n"))
										
										
						
		
	
						
		
		
		default: fmt.Println("This is default case")
		         
		
		}
		
		defer db.Close()
 }
 


func main() {






	fmt.Println("Launching server... (type ctrl-c to close the server)")
     
	// listen on all interfaces
	ln, _ := net.Listen("tcp", ":12000")

	// run loop forever (or until ctrl-c)
	for {
		// accept connection on port
		conn, _ := ln.Accept()
		
		go goclienthandle(conn);
	
		
		
	}
	
}
