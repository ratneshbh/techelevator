let questions;

document.addEventListener('DOMContentLoaded',
    ()=>{
        init("neat");
    }
);

function init(e){

    fetch('https://opentdb.com/api.php?amount=10&type=multiple')
    .then(response => response.json())
    .then(data => {
        console.log(data);
        questions = data;
        displayQuestion(0);
      })
    .catch(e=> console.log(e));

}

function displayQuestion(i){

    const q = questions.results[i];
    const questionText = document.getElementById("question");
    questionText.innerText = q.question;
    //ol->li/li
    const correctAnswerText = document.getElementById("answers");
    //remove children
    while (correctAnswerText.firstChild) {
        correctAnswerText.removeChild(correctAnswerText.lastChild);
    }

    questionLI = document.createElement("li");
    questionLI.innerText = q.correct_answer;
    correctAnswerText.appendChild(questionLI);

    const incorrectAnswers = q.incorrect_answers;
    incorrectAnswers.forEach(answer =>
        {
            questionLI = document.createElement("li");
            questionLI.innerText = answer;
            correctAnswerText.appendChild(questionLI);
        }
    );
}

function displayQuestions(){

    questions.results.forEach(q => {
        
        const questionText = document.getElementById("question")
        console.log(q);
        questionText.innerText = q.question;
        //ol->li/li
        const correctAnswerText = document.getElementById("answers");
        
        questionLI = document.createElement("li");
        questionLI.innerText = q.correct_answer;
        correctAnswerText.appendChild(questionLI);

        const incorrectAnswers = q.incorrect_answers;
        incorrectAnswers.forEach(answer =>
            {
                questionLI = document.createElement("li");
                questionLI.innerText = answer;
                correctAnswerText.appendChild(questionLI);
            }
        );
    });
}

