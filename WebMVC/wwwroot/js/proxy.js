console.clear();

const obj = {
    id: 1,
    _Name: "Sasov",
    Name: "Alex"
};

var proxy = new Proxy(obj, {
    get(target, prop) {
        let res;
        let props = prop.split("_");
        res = props.map(pr=>target[pr]).join(" ");
        return res;
    },
    set(target, prop, value) {
        target[prop] = value;
    },
    has(target, prop) {
        if (prop.startsWith("_"))
            res = void 0;
        else Reflect.ownKeys(target).includes(prop);
    }
});