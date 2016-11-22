
package main

import (
	"fmt"
	_ "src/github.com/encryption"
)

func main() {
    fmt.Printf("qweasd*653\n")
	str:=encryption.get_code("qweasd*653")
	fmt.Printf("after conversion...... \n")
	fmt.Printf(str)
	fmt.Printf("convert to original...... \n")
	str2:=encryption.get_passwd(str)
	fmt.Printf(str2)
}