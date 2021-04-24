/**
 * Write a function called isAdmitted. It will check entrance
 * scores and return true if the student is admitted and
 * false if rejected. It takes three parameters:
 *
 *     * gpa
 *     * satScore (optional)
 *     * recommendation (optional)
 *
 * Admit them--return true--if:
 * gpa is above 4.0 OR
 * SAT score is above 1300 OR
 * gpa is above 3.0 and they have a recommendation OR
 * SAT score is above 1200 and they have a recommendation
 * OTHERWISE reject it
 *
 * @param {number} gpa the GPA of the student, between 4.2 and 1.0
 * @param {number} [satScore=0] the student's SAT score
 * @param {boolean} [recommendation=false] does the student have a recommendation
 * @returns {boolean} true if they are admitted
 */
function isAdmitted(gpa, satScore=0, recommendation=false){
    if ((gpa > 4.0) ) {
        return true;
    }
    else if ((satScore > 1300)){
        return true;
    }
    
    else if ((gpa > 3.0 && recommendation)){
        return true
    }
    else if (satScore > 1200){
        return true;
    }
    else {
        return false;
    }
    
}
/**
 * Write a function called useParameterToFilterArray that takes an anonymous
 * function and uses that in the `unfilteredArray` filter function. Return the result.
 *
 * @param {function} filterFunction the function to filter with
 * @returns {number[]} the filtered array
 */
let unfilteredArray = [1, 2, 3, 4, 5, 6];

function useParameterToFilterArray(filterFunction) {
    let filteredNumbers = unfilteredArray.filter(filterFunction)
    return filteredNumbers;
}

// function useParameterToFilterArray((function ()) {
//     let filteredNumbers = unfilteredArray.filter((number) => {
//         return number;
//     });
// }

// Not certain about how to pass the anonymous function into the unfilteredArrray filter function 
//my guess:
// function useParameterToFilterArray(){
//     let filteredNumbers = unfilteredArray.filter((number) => {
//         return filteredNumbers;
//     });
// }


/**
 * Write a function called makeNumber that takes two strings
 * of digits, concatenates them together, and returns
 * the value as a number.
 *
 * So if two strings are passed in "42293" and "443", then this function
 * returns the number 42293443.
 *
 * @param {string} first the first string of digits to concatenate
 * @param {string} [second=''] the second string of digits to concatenate
 * @returns {number} the resultant number
 */

function makeNumber (first, second=''){
    // let num = first + second; 
    // number = Number(num);
    // return number;
    let n = ''; 
    first = first.split("");
    second = second.split("");
    first.forEach(element => {
        n = n + element
    });
    second.forEach(element => {
        n = n + element 
    });
    number = Number(n)
    return number; 

}

// function makeNumber (first, second='') {
//     let number = first + second; 
//     return number;
// }

/**
 * Write a function called addAll that takes an unknown number of parameters
 * and adds all of them together. Return the sum.
 *
 * @param {...number} num a series of numbers to add together
 * @returns {number} the sum of all the parameters (or arguments)
 */


// function addAll (num){
//     let sum = 0            //be careful - reminder to self - assign default value to variable
//     if (num && num.length > 0) {
//     num.map((element) => {
//         sum += element; 
//     })}
//     number = sum;
//     return number; 
// }
function addAll (num) {
    // let num = ''; 
    let number = 0;           //assign default value to variable otherwise arguments are undefined and automatically returns zero!
    for(let i = 0; i < arguments.length; i++){
        number += arguments[i]; 
    }
    return number; 
}

/*
 * Write and document a function called makeHappy that takes
 * an array and prepends 'Happy ' to the beginning of all the
 * words and returns them as a new array. Use the `map` function.
 */
/**
 * Takes an array and applies a map function to return a string prepended to the beginning of each item in the array to return a new array.
 * @param {[]} arr that is taken by the function 
 * @returns {[]} the new array with filtered elements
 */
function makeHappy(arr){         //arr is an array
     
    let newArray = arr.map((number) => {
        return 'Happy ' + number;
        
        
    })
    return newArray;
}
/*
 * Write and document a function called getFullAddressesOfProperties
 * that takes an array of JavaScript objects containing the
 * following keys:
 *     * streetNumber
 *     * streetName
 *     * streetType
 *     * city
 *     * state
 *     * zip
 *
 * and returns an array of strings that turns the JavaScript objects
 * into a mailing address in the form of:
 *     streetNumber streetName streetType city state zip
 *
 * Use `map` and an anonymous function.
 */

/**
 * Takes an array of objects containing keys consisting of address descriptors and apply the map function. Returns an array of strings resembling a mailing address. 
 * @param {array} addresses
 * @returns 
 */
// let x = {}  //this is an object
function getFullAddressesOfProperties(addresses){

    let arr = addresses.map((obj) => {
        return obj.streetNumber.toString() +  " " + obj.streetName.toString() +  " " +obj.streetType.toString() +  " " +obj.city.toString() +  " " +obj.state.toString() +  " " +obj.zip.toString() 
        
    })
    return arr; 
}
// function getFullAddressesOfProperties(){
//     let fullAddress = [];
//     let fullAddress = new Map()
//     fullAddress.set(streetNumber)
//     fullAddress.set(streetName)
//     fullAddress.set(streetType)
//     fullAddress.set(city)
//     fullAddress.set(state)
//     fullAddress.set(zip)
    
//     return fullAddress

// }
/*
 * Write and document a function called findLargest.
 *
 * Using `forEach`, find the largest element in an array.
 * It must work for strings and numbers.  //ok, how?
 */

/**
 * Takes givenArray an array that can be strings or numbers and returns the largest element of the array after looping through with a forEach.
 * @param {[]} givenArray an array that a forEach function loops through in order to find the largest element
 * @returns {string or number} largest element of the array after foreach function is applied 
 */
function findLargest(givenArray){
    let largest = givenArray[0]; 
    givenArray.forEach(element => {
        if (largest < element){
            largest = element;
        }
    
    });
    return largest;
}
/*
 * CHALLENGE
 * Write and document a function called getSumOfSubArrayValues.
 *
 * Take an array of arrays, adds up all sub values, and returns
 * the sum. For example, if you got this array as a parameter:
 * [
 *   [1, 2, 3],
 *   [2, 4, 6],
 *   [5, 10, 15]
 * ];
 *
 * The function returns 48. To do this, you will use two nested `reduce`
 * calls with two anonymous functions.
 *
 * Read the tests to verify you have the correct behavior.
 */
