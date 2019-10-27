/// <reference path="vue.d.ts" />
Vue.component('userlistinfo', {
    props: ["user"],
    template: "<div>|  {{user.Name}}  |</div>"
});
Vue.component('carlistinfo', {
    props: ["car"],
    template: "<div>|  {{car.Number}}  |</div>"
});
Vue.component('orderlistinfo', {
    props: ["order"],
    template: "<div><span>|  {{order.Id}}  |</span>\n               <span>{{order.orderDate}}  |</span>\n               <span>{{getZones(order)}}  |</span>\n               <span>{{order.User.Name}}  |</span>\n               <span>{{order.Car.Number}}  |</span></div>",
    methods: {
        getZones: function (order) {
            var zones = order.akCheck ? "AK-2 " : "";
            zones += order.ackCheck ? "ACK-1 " : "";
            zones += order.apckCheck ? "APCK-3" : "";
            return zones;
        }
    }
});
var app4 = new Vue({
    el: '#app',
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
                    Id: 1,
                    Name: "User 1"
                },
                Car: {
                    Id: 2,
                    Number: "343GT44E"
                }
            },
            {
                Id: 2,
                orderDate: "02.01.2019",
                akCheck: true,
                apckCheck: true,
                ackCheck: false,
                User: {
                    Id: 3,
                    Name: "User 3"
                },
                Car: {
                    Id: 2,
                    Number: "343GT44E"
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
        addOrder: function () {
            var _this = this;
            var user = this.users.filter(function (x) { return x.Id == _this.userId; })[0];
            var car = this.cars.filter(function (x) { return x.Id == _this.carId; })[0];
            var order = {
                Id: this.orders.length + 1,
                orderDate: this.orderDate,
                akCheck: this.akCheck,
                ackCheck: this.ackCheck,
                apckCheck: this.apckCheck,
                User: {
                    Id: this.userId,
                    Name: user.Name
                },
                Car: {
                    Id: this.carId,
                    Number: car.Number
                }
            };
            this.orders.push(order);
        }
    }
});
//# sourceMappingURL=page.calc.components.js.map