const readline = require('readline');

const rl = readline.createInterface({
  input: process.stdin,
  output: process.stdout
});

rl.question('', () => {
  rl.question('', (num1) => {
    rl.question('', (num2) => {

      const a = num1.split(' ').map(Number);
      const b = num2.split(' ').map(Number);

      function isWin(a, b) {
        if (a.every((item, index) => b[index] === item)) {
          return 'YES';
        }

        if (a.some(item => !b.includes(item))) { // если хотя бы один элемент массива a нет в массиве b
          return 'NO';
        }

        if (a.length !== b.length) { // если длина массивов разная
          return 'NO';
        }

        const { startIndex, endIndex } = a.reduce((acc, digit, index) => {
          if (digit !== b[index] && acc.startIndex === -1) {
            acc.startIndex = index;
          }

          if (digit !== b[index] && acc.startIndex !== -1) {
            acc.endIndex = index;
          }

          return acc;
        }, {
          startIndex: -1,
          endIndex: -1,
        })

        const aCopy = a.slice(startIndex, endIndex + 1).sort()
        const bCopy = b.slice(startIndex, endIndex + 1);

        if (aCopy.every((item, index) => bCopy[index] === item)) {
          return 'YES';
        }

        return 'NO';
      }

      console.log(isWin(a, b));
      rl.close();
    });
  });
});