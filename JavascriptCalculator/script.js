(() =>{
    //Elements
    var numbers = document.getElementsByClassName("grid-number");
    var multiply = document.getElementById("multiply");
    var divide = document.getElementById("divide");
    var add = document.getElementById("add");
    var subtract = document.getElementById("subtract");
    var equal = document.getElementById("equal");
    var total = document.getElementById("total");
    
    const display = document.querySelector('.input');
    
    console.log(numbers);
    console.log(multiply);
    console.log(divide);
    console.log(add);
    console.log(subtract);
    console.log(equal);

    //Classes
    class Calculator {
        constructor() {
            this.total
            this.temp
            this.operator = "none"
        }

        addToTemp(number) {
            this.temp = this.temp * 10 + parseInt(number)
            this.display();
        }

        equal() {
            this.temp = 0;
            this.display();
        }

        display(){
            total.innerText = this.temp;
            console.log(this.temp);
        }

    }

    var calc = new Calculator();

    //Listeners
    for(var i = 0; numbers.length; i++ ){
        numbers[i].addEventListener("click", function(){
            calc.addToTemp(this.innerText);
        });
    }
    equal.addEventListener("click", () => {
        calc.equal();
    })
})()