"use strict";

function reverseString(str) {
    var splitString = str.split(""); 
    //console.log(splitString) 
    //[ 'H', 'e', 'l', 'l', 'o' ]

    var reverseArray = splitString.reverse();
    //console.log(reverseArray)
    //[ 'o', 'l', 'l', 'e', 'H' ]

    var joinArray = reverseArray.join(""); 
    //console.log(joinArray)
    //olleH

    return joinArray; 
}
 
console.log(reverseString("Hello"))