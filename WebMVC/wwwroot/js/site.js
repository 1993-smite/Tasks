// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// #region prototype
Date.prototype.getFullDateTime = function () {
    console.log("prototype --- ",`${this.getDate()}.${this.getMonth()}.${this.getFullYear()}`);
};

let dt = new Date();
dt.getFullDateTime();
// #endregion
/////////////////////////////////////////////////////

let user = { Id: 1, Name: "Alex" };
let user1 = { Id: 2, Name: "Ivan" };

// #region bind, call, apply
function show() {
    console.log("bind --- " ,`Id = ${this.Id} --- Name = ${this.Name} --- context = ${this}`);
}

function bind(context, func) {
    return () => func.bind(context); //apply, call, bind
}

user.show = bind(user, show)();
user1.show = bind(user1, show)();

user.show();
user1.show();
// #endregion

// #region декомпозиция
let { Id: id, Name: name } = user;

console.log("декомпозиция --- ",`id = ${id} ---- name = ${name}`);
// #endregion

// #region object user
console.groupCollapsed("object user");
for (let key in user) {
    console.log(key,user[key]);
}
console.groupEnd();
// #endregion

// #region iterate
function* iterate(index) {
    let result = 0;
    for (let i = 0; i < index; i++) {
        yield i;
    }
}

console.groupCollapsed("iterate");
for (let val of iterate(6)) {
    console.log(val);
}
console.groupEnd();
// #endregion

// #region Object to Array
console.groupCollapsed("Object to Array")
const arrUser = Object.values(user);
console.log(arrUser);

for (let [key, val] of Object.entries(user)) {
    console.log(key,val);
}

console.groupEnd();
// #endregion

// #region reduce
const array1 = [1, 2, 3, 4];
const reducer = (accumulator, currentValue) => accumulator + currentValue;

console.groupCollapsed("reduce");
console.log("reduce --- ",array1.reduce(reducer));
console.log("reduce --- ", array1.reduce(reducer, 15));
console.groupEnd();
// #endregion

// #region map
var names = ['HTML', 'CSS', 'JavaScript'];

var nameLengths = names.map(function (name) {
    return name.length;
});

var nameResult = names.map(function (name) {
    return `${name} --- language`;
});
console.groupCollapsed("map");
console.log("map --- ", nameLengths);
console.log("map --- ", nameResult);
console.groupEnd();
// #endregion

// #region var, let
console.groupCollapsed("var, let");
console.log(res);
var res = 434;
let lres = 433;
function test() {
    var res = 444;
    let lres = 443;
    {
        var res = 555;
        let lres = 554;
        console.log(res, lres);
    }
    console.log(res,lres);
}
console.log(res, lres);
test();
console.groupEnd();
// #endregion

// #region add()()

function add(a) {
    let sum = a || 0;
    function addp(p) {
        if (p) sum += p;
        return sum;
    }
    return addp;
}

function add1(a) {
    let sum = a || 0;
    function addp1(p) {
        if (p) {
            sum += p;
            return addp1;
        }
        return sum;
    }
    //addp1.valueOf = () => sum;
    return addp1;
}

function add2(a) {
    let sum = a;
    function addp2(p) {
        sum += p;
        return addp2;
    }
    addp2.valueOf = () => sum;
    return addp2;
}

console.groupCollapsed("add()()");
console.log("add(2)(3) --- ", add(2)(3));
console.log("add(2)() --- ", add(2)());
console.log("add1(2)(3)() --- ", add1(2)(3)());
console.log("add1(2)() --- ", add1(2)());
console.log("add2(2)(3) --- " + add2(2)(3));
console.groupEnd();
// #endregion

// #region checkParam
console.groupCollapsed("checkParam arguments");
function checkParam() {
    let arg = Array.prototype.slice.call(arguments);
    console.log(arg);
    console.log(arg.length);
}
checkParam(3, 4, 5, 6);
console.groupEnd();
// #endregion