// Quando a gente declara uma função ela se lembra do contexto onde ela foi declarada

function soma(x) {
   return function (y) {
      return x + y;
   }
}

console.log(soma(10)(20));

const somaParcial = soma(10);

console.log(somaParcial(30));
console.log(somaParcial(40));