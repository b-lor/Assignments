"use strict";
function toUpper(str) {
   var splitStr = str.toLowerCase().split(' ');
     //console.log(splitStr);
     //[ 'hello', 'world' ]

   for (var i = 0; i < splitStr.length; i++) {
       splitStr[i] = splitStr[i].charAt(0).toUpperCase() + splitStr[i].substring(1);     
        //console.log(splitStr[i]);
        //Hello
        //World
        //console.log(splitStr[i].charAt(0).toUpperCase());
        //H
        //W
        //console.log(splitStr[i].substring(1));
        //H
        //ello
        //W
        //orld
;
   }
   // Directly return the joined string
   return splitStr.join(' '); 

}

  console.log(toUpper("hello world"));

