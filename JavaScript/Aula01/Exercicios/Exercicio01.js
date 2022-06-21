const nums = [5, 50, 80, 1, 2, 3, 5, 8, 7, 11, 15, 22, 27]

//Tire os 3 primeiros números e adicione uma array com 5 numeros no lugar -- splice e spread

array2 = [0, 0, 0, 0, 0]
var novo = [array2, ...nums.splice(3)]
console.log(novo)

var novo = [...novo].filter(v=> v % 3 ==0)
console.log(novo)

var novo = [...novo.map(v=> v + v)]
console.log(novo)

var novo = novo.reduce((preValue, currentValue) => preValue + currentValue, -200)
console.log(novo)