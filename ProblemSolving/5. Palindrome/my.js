"use strict";

var name = window.prompt("What is your name").toLowerCase();
var same;

function palindrome(str) {
    var lowRegStr = str.toLowerCase();    
    var splitString = str.split(""); 
    var reverseArray = splitString.reverse();
    var joinArray = reverseArray.join(""); 
    same = joinArray === lowRegStr;
}
palindrome(name)

console.log(same);