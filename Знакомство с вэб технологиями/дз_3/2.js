function Gretting(namePush) {
    ansverGetting = `Привет, ${namePush}!`;
    return ansverGetting;
};

let nameUser = prompt('Как вас зовут?');
alert(Gretting(nameUser));
console.log(Gretting(nameUser));
