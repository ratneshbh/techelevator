// add pageTitle
let pageTitle = 'My Shopping List'

// add groceries
let groceries = ['apples', 'bittermelon', 'watermelon', 'butter', 'bread', 'peppers', 'turmeric', 'salt', 'peaches', 'ice cream']
/**
 * This function will get a reference to the title and set its text to the value
 * of the pageTitle variable that was set above.
 */
function setPageTitle() {
  let pageTitleElement = document.getElementById('title'); 

  pageTitleElement.innerText='My Shopping List'
    //document.title="My Shopping List"
  //  document.getElementById('title')
 // console.log(pageTitleElement)
}
  

/**
 * This function will loop over the array of groceries that was set above and add them to the DOM.
 */
function displayGroceries() {
  let unorderedList = document.getElementById('groceries');
  groceries.forEach((item) => {
    let liTag = document.createElement('li');
    liTag.innerText = item; 
    unorderedList.appendChild(liTag); 
  }); 
  //const items = document.querySelectorAll('.shopping-list li')
  
}

/**
 * This function will be called when the button is clicked. You will need to get a reference
 * to every list item and add the class completed to each one
 */
function markCompleted() {}

setPageTitle();

displayGroceries();

// Don't worry too much about what is going on here, we will cover this when we discuss events.
document.addEventListener('DOMContentLoaded', () => {
  // When the DOM Content has loaded attach a click listener to the button
  const button = document.querySelector('.btn');
  button.addEventListener('click', markCompleted);
});
