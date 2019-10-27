class Film {
    Id: number;
    Name: string;

    constructor(id: number, name: string) {
        this.Id = id;
        this.Name = name;
    }
}

class User {
    Id: number;
    Name: string;

    constructor(id: number, name: string) {
        this.Id = id;
        this.Name = name;
    }
}

class OrderUserFilm {
    Id: number;
    Name: string;
    Film: Film;
    User: User;

    constructor(id: number, name: string, film: Film, user: User) {
        this.Id = id;
        this.Name = name;
        this.Film = film;
        this.User = user;
    }
}