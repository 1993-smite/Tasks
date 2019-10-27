console.clear();

Date.prototype.getFullDateTime = function () {
    return `${this.getDate()}.${this.getMonth()}.${this.getFullYear()}  ${this.getHours()}:${this.getMinutes()}:${this.getSeconds()}.${this.getMilliseconds()}`;
};

console.time("promise time");
let prom = [];
function getProm() {
    prom.push(new Promise(resolve => {
        console.groupCollapsed("Promise array");
        setTimeout(() => resolve("result"), 100);
    }).then(() => console.timeLog("first --- " + (new Date()).getFullDateTime())));
    for (let i = 0; i < 10; i++) {
        prom.push(new Promise(
            resolve => {
                setTimeout(() => {
                    $.post("User/GetUser", { id: i }, function (data) {
                        console.groupCollapsed(`User --- ${data.id}`);
                        for (let [key, val] of Object.entries(data)) {
                            console.log(key, val);
                        }
                        console.groupEnd();
                        if (typeof resolve === "function")
                            resolve(i);
                    });
                }, 2000);
            }
        ).then(() => console.timeLog("prom --- " + (new Date()).getFullDateTime())));
    }
}
getProm();
Promise.race(prom).then(
    () => {
        console.timeLog("first prom is over --- " + (new Date()).getFullDateTime());
    }
);

Promise.all(prom).then(() => {
    console.timeLog("last prom is over --- " + (new Date()).getFullDateTime());
    console.timeEnd();
    console.groupEnd();
});

let promise;
function getPromOne() {
    promise = new Promise(resolve => {
        setTimeout(() => {
            console.groupCollapsed("Promise");
            console.log("prom ", -1);
            resolve(-1);
        }, 6000);
    });
    for (let i = 0; i < 10; i++) {
        promise = promise.then(
            resolve => {
                setTimeout(
                    () => {
                        console.log("prom ", i);
                        if (typeof resolve === "function")
                            resolve(i);
                    }
                    , 2000);
            }
        );
    }
    //promise = promise.then(resolve => console.groupEnd());
}
getPromOne();
Promise.all([promise]).then(() => {
    console.groupEnd();
});