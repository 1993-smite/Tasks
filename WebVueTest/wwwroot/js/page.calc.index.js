/// <reference path="vue.d.ts" />
var app = new Vue({
    el: '#app',
    data: {
        message: 'Hello Vue!',
        expression: "",
        result: 0
    },
    methods: {
        setMessage: function (event) {
            this.message = event.target.value;
        },
        setExpression: function (event) {
            this.expression += event;
            if (this.expression.length > 0) {
                this.result = eval(this.expression);
            }
        }
    }
});
var app1 = new Vue({
    el: '#app1',
    data: {
        link: 'google.ru',
        label: "Google",
        checkModel: false
    },
    methods: {
        getCheck: function () {
            return this.checkModel;
        }
    }
});
var app2 = new Vue({
    el: '#app2',
    data: {
        users: [
            {
                Id: 1,
                Name: "User 1"
            },
            {
                Id: 2,
                Name: "User 2"
            },
            {
                Id: 3,
                Name: "User 3"
            }
        ],
        cars: [
            {
                Id: 1,
                Number: "123NU434"
            },
            {
                Id: 2,
                Number: "343GT44E"
            }
        ],
        orders: [
            {
                Id: 1,
                orderDate: "01.01.2019",
                akCheck: true,
                apckCheck: false,
                ackCheck: false,
                User: {
                    Id: 1
                },
                Car: {
                    Id: 2
                }
            },
            {
                Id: 2,
                orderDate: "02.01.2019",
                akCheck: true,
                apckCheck: true,
                ackCheck: false,
                User: {
                    Id: 3
                },
                Car: {
                    Id: 2
                }
            }
        ],
        akCheck: false,
        apckCheck: false,
        ackCheck: false,
        orderDate: "03.01.2019",
        userId: -1,
        carId: -1
    },
    methods: {
        getCar: function (order) {
            var cars = this.cars.filter(function (x) { return x.Id == order.Car.Id; });
            return cars[0];
        },
        getUser: function (order) {
            var users = this.users.filter(function (x) { return x.Id == order.User.Id; });
            return users[0];
        },
        getZones: function (order) {
            var zones = order.akCheck ? "AK-2 " : "";
            zones += order.ackCheck ? "ACK-1 " : "";
            zones += order.apckCheck ? "APCK-3" : "";
            return zones;
        },
        addOrder: function () {
            var order = {
                Id: this.orders.length + 1,
                orderDate: this.orderDate,
                akCheck: this.akCheck,
                ackCheck: this.ackCheck,
                apckCheck: this.apckCheck,
                User: {
                    Id: this.userId
                },
                Car: {
                    Id: this.carId
                }
            };
            this.orders.push(order);
        }
    }
});
//# sourceMappingURL=page.calc.index.js.map