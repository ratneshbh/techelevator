const header = document.getElementById("header");
header.innerText = "New Header";

const firstDiv = document.querySelector("div");
firstDiv.setAttribute("class", "colorized");

const allDivs = document.querySelectorAll("div");

allDivs.forEach(
    (div, idx) => {
        if (idx > 0){
            div.style.backgroundColor = "purple"
        }
    }
)

const newLI = document.createElement("li");
newLI.innerText = "im new here";
document.getElementById("menu").appendChild(newLI);

const newSpan = document.createElement("span");
newSpan.innerText = "hi there";

const content = document.getElementById("content");
content.insertAdjacentElement("afterend", newSpan)