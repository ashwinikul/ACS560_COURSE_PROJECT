
//  Server Side Code V1.1
//  Created By Ashwini 

package main
import (
	"database/sql"
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
Modifieddate string

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

type adds  struct{
addid int 
add_name string
userid int
add_details string
block int
createdBy  string
UpdatedBy string
Modifieddate time.Time
}

type comments  struct{
commentid int
addid int 
userid int
comment string
block int
createdBy  string
UpdatedBy string
Modifieddate time.Time

}


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


func Slice_Atoi(strArr []string) ([]int, error) {
    // NOTE:  Read Arr as Slice as you like
    var str string                           // O
    var i int                                // O
    var err error                            // O

    iArr := make([]int, 0, len(strArr))
    for _, str = range strArr {
        i, err = strconv.Atoi(str)
        if err != nil {
            return nil, err                  // O
        }
        iArr = append(iArr, i)
    }
    return iArr, nil
}

// For Multiple client handling
func goclienthandle(conn net.Conn) {
 
var x string
//var y bool = false
var username string
var usertype string
var pass string
var P userlogin
var PD userdetails
var data_received string=""
var SEC add_security 
//var a1 adds
//Database Connection 	
db, err := sql.Open("sqlite3", "/home/ashwini/work/DB1")
if err != nil { panic(err) }
if db == nil { panic("db nil") }
	
fmt.Println("Database Connection Established...")
	
	
// data receive from cient
		
message, _ := bufio.NewReader(conn).ReadString('\n')
data_received=string(message)
data_received=strings.TrimSpace(data_received)
fmt.Println(" Register data Received:", data_received)
result := strings.Split(data_received, "|") // each elements from client data are seperated by | identifier.
x=string(result[0]) // result[0] will give the which operation event have send the data
x=strings.TrimSpace(x) // will remove spaces
		
switch x {
		
		
		case "Login": 
						// this block is designed for login operation
						
						fmt.Println("Operation Received:", result[0])
						fmt.Println("Username Received:", result[1])
						username=string(result[1])
						username=strings.TrimSpace(username)
						//fmt.Println("Pass Received:", result[2])
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
										
						if(username == P.user_name && pass == P.u_password) {
																				fmt.Println("Success")
																				conn.Write([]byte(P.user_type + "\n"))
																			} else {
																						fmt.Println("Failed")
																						conn.Write([]byte("Failed" + "\n"))
																					}

					  
		case "Register", "SMRegister","Profile_Change": 
		
		
						// this block is designed for Register operation
						
		
						// determining usertype
						
						if x=="Register" {
						usertype="enduser"
						} else if x=="Profile_Change" {
						usertype="enduser"
						} else {
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
						 
						//message, _ = bufio.NewReader(conn).ReadString('\n')
						username=""
						username=result[1]
						//username=strings.TrimSpace(username)
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
						profileData=username + "|" + string(PD.userid) + "|" + PD.user_Full_name + "|" + PD.gender + "|" + PD.Location + "|" + PD.Contact + "|" + PD.SecurityQus + "|" + PD.SecurityAns + "|" + P.u_password
						fmt.Print(profileData)
						conn.Write([]byte(profileData + "\n"))
						//conn.Write([]byte("4" + "\n"))

						
		case "SM_Get_Data": // Sending profile data to user.			
						 
						//message, _ = bufio.NewReader(conn).ReadString('\n')
						username=""
						username=result[1]
						//username=strings.TrimSpace(username)
						rows, err := db.Query("select U.userid, U.user_name, S.Type, IFNULL(S.addid,''), IFNULL(S.commentid,''), IFNULL(S.block,'') , S.Modifieddate ,CASE WHEN S.type='add' then A.add_details WHEN S.type ='comment' then C.comment END DATA_text from userlogin U INNER JOIN add_security S on U.userid=S.userid LEFT JOIN adds A on S.addid=A.addid LEFT JOIN Comments C on s.commentid =C.commentid where U.user_name=$1 and S.Block is NULL and (S.addid IS NOT NULL OR S.Commentid IS NOT NULL) order by S.Modifieddate ASC",username )
						i:=0
						if err != nil {
										log.Fatal(err)
									  }
										defer rows.Close()
						for rows.Next() {
											err := rows.Scan(&SEC.userid , &P.user_name , &SEC.a_type, &SEC.addid ,&SEC.commentid, &SEC.block, &SEC.Modifieddate, &SEC.data_text)
											if err != nil {
															log.Fatal(err)
														  }
														  i++
											fmt.Println(i)
										}
						var profileData string
						var count string
						count=strconv.Itoa(i)
						fmt.Println(count)
						conn.Write([]byte(count + "\n"))
						 for k:=0; k<i; k++ {
						profileData=SEC.a_type + "|" + string(SEC.addid) + "|" + string(SEC.commentid) + "|" + SEC.data_text + "|" + strconv.Itoa(SEC.userid) + "|" + SEC.block 
						fmt.Println(profileData)
						conn.Write([]byte(profileData + "\n"))
						}
						//conn.Write([]byte("4" + "\n"))
		
		
		case "SM_ALLOW" : // security manager role: allow or decline comments and adds : this is test code - not finalize yet
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
						

							
		
		case "User_Home": 
		
		case "Admin_Home": 
		
		case "SecMgr_Home": 
		
		case "Forgot_Password": 
		
		
		default: fmt.Println("This is defailt case")
		         
		
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
