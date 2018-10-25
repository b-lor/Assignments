"use strict";

function countWords() {

    var word = "aaabbbbbccccaacccbbbaaabbbaaa";
    var result = "";
    
    var counter = 1;
    for (var i = 0; i <= word.length; i++) {
      if (word[i] != word[i + 1]) {
        result = result + counter + word[i];
        counter = 1;
      } else {
        counter++;
      }
    }
  
    return result.length < word.length ? result : word;
  
  }
  
  console.log(countWords());