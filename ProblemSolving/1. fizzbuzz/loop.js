"use strict";

  for (let i = 1; i <= 100; i++){
    if ((0 == i % 3) && (0 == i % 5)){
      console.log ("fizzbuzz");
    } 

    else if (0 == i % 5) {
      console.log("buzz");
    } 
    
    else if (0 == i % 3){
          console.log("fizz");
    } 
    
    else 
    {

      console.log (i);
      }
  }
