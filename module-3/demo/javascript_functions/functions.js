function doubleV1(num)
    {
        return num + num;
    }
//assign const to anonymous function
const doubleV2 = function(num)
    {
        //undefined without return
        return num + num;
    }
//if no function keyword, must use arrow function
const doubleV3 = (num) =>
    {
        //undefined without return
        return num + num;
    }
//returns value. only works if function body is single line
const doublev4 = num => num + num;

const x = () => 123;

function callDoubleV1(num, doubleFunction)
    {
        return doubleFunction(num);
    }

const callDoubleV2 = (num, func) => 
    {
        return func(num);
    }

const callDouble3 = (num, func) => func(num);

const days = ['mon','tue','wed','thu'];

days.forEach(

    (val, idx) => console.log(`Current value is ${val} it is located at index ${idx}`)

);