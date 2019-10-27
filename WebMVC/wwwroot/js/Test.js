
function fizzbus(n) {
    for (let i = 1; i <= n; i++) {

        let aliquotTo3 = i % 3 == 0;
        let aliquotTo5 = i % 5 == 0;
        let res = "";

        if (aliquotTo3 && aliquotTo5)
            res = "fizzbuss";
        else if (aliquotTo3)
            res = "fizz";
        else if (aliquotTo5)
            res = "buzz";
        else
            res = +i;

        console.log(res);
    }
}

fizzbus(5);