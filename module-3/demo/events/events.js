//monitorEvents($0); //shows all browser events
document.addEventListener("DOMContentLoaded", 
//wait until browser parses html into a DOM then call function
    () => {
        const h1  = document.getElementById("header");
        h1.innerText = "Dynamically set by the power of Javascript";
    
        h1.addEventListener("click", handleClick);
        h1.addEventListener("dblclick", handleDoubleClick);

        const mouse  = document.getElementById("mouse");
        mouse.addEventListener("mousemove", handleMouseMove);

        document.getElementById("list").addEventListener("click", handleClick)
/* //wont affect dynamic element
const allLi = document.querySelectorAll("li");
allLi.forEach(

    (li) => {
       // li.addEventListener("click", handleClick)
        
    }

);
*/
        const ul = document.getElementById("list");
        const li = document.createElement("li");

        li.innerText= "two";
        ul.appendChild(li);

        document.addEventListener("keyup",
        
                (e) => {
                    mouse.innerText = mouse.innerText + e.key;
                }

            )
    }
);

function handleClick (e){
    //thing that was clicked on
    console.log(e.target.innerText);
    //thing that has the event event
    console.log(e.currentTarget.innerText);
}

function handleDoubleClick(){
    console.log("dblclicked");
}

function handleMouseMove(eventObject){

    const pcoords = document.getElementById("coordinates");
    pcoords.innerText = `x: ${eventObject.screenX} y: ${eventObject.screenY}`;

}
