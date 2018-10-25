"use strict";

var myNumber = window.prompt("Enter Your Number Here:");

function fibonacci(num) {
    let fib = [1,1];
    for (let i = 2; i <= num; i++) {
      fib.push(fib[i-1] + fib[i-2]);
    }

  return fib.filter(function(item) {
    return item > myNumber
  });
}

 console.log(fibonacci(50));