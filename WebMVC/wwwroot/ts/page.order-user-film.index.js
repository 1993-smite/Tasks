/*/// <reference path="angular.d.ts" />*/
/// <reference path="order-user-film.ts" />
/*angular.module('orderUserFilmApp', [])
    .controller('orderUserFilmController', function () {
        var orderUserFilmList = this;
        orderUserFilmList.listItem = [
            new OrderUserFilm(1, "test", new Film(1,"film 1"), new User(1,"user 1")),
            new OrderUserFilm(2, "test 1", new Film(2, "film 2"), new User(2, "user 2")),
            new OrderUserFilm(3, "test 2", new Film(3, "film 3"), new User(3, "user 3"))
        ];

        orderUserFilmList.addItem = function () {
            orderUserFilmList.todos.push({ text: orderUserFilmList.todoText, done: false });
            orderUserFilmList.todoText = '';
        };

        orderUserFilmList.remaining = function () {
            var count = 0;
            angular.forEach(orderUserFilmList.todos, function (todo) {
                count += todo.done ? 0 : 1;
            });
            return count;
        };

        orderUserFilmList.archive = function () {
            var oldTodos = orderUserFilmList.todos;
            orderUserFilmList.todos = [];
            angular.forEach(oldTodos, function (todo) {
                if (!todo.done) orderUserFilmList.todos.push(todo);
            });
        };
    });*/ 
//# sourceMappingURL=page.order-user-film.index.js.map