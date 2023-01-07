Math.round
let user_input = Number.parseFloat(prompt('Введите температуру в градусах Цельсия'));
alert(`Цельсия: ${user_input}\nФаренгейт: ${Math.round(((9 / 5) * user_input + 32)*10)/10}`)
