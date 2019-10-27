var Film = /** @class */ (function () {
    function Film(id, name) {
        this.Id = id;
        this.Name = name;
    }
    return Film;
}());
var User = /** @class */ (function () {
    function User(id, name) {
        this.Id = id;
        this.Name = name;
    }
    return User;
}());
var OrderUserFilm = /** @class */ (function () {
    function OrderUserFilm(id, name, film, user) {
        this.Id = id;
        this.Name = name;
        this.Film = film;
        this.User = user;
    }
    return OrderUserFilm;
}());
//# sourceMappingURL=order-user-film.js.map