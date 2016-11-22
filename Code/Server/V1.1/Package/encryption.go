package encryption

//import "fmt"

func get_passwd(code string) (pass_w string) {

	byte_data_array := []byte(code)

	s := string(byte_data_array [:])

	m:=make([]int,len(s))

	for k:=0; k<len(s); k++ {
	m[k]=int(s[k]) - k

	if string(m[k]-1)=="|" {
	m[k]=int(s[k]) - 1
	}
	pass_w=pass_w+string(m[k])
	}
	return pass_w
}

func get_code(pass_w string) (code string)  {

	byte_data_array := []byte(pass_w)



	s := string(byte_data_array [:])

	m:=make([]int,len(s))

	for k:=0; k<len(s); k++ {
	m[k]=int(s[k]) + k

	if string(m[k])=="|" {
	m[k]=int(s[k]) + 1
	}
	code=code+string(m[k])
	}

	return code
}

