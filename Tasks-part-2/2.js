const readline = require('readline');

const rl = readline.createInterface({
  input: process.stdin,
  output: process.stdout
});

const dict = {
  s: 1,
  h: 1,
  e: 1,
  r: 1,
  i: 1,
  f: 2,
}

rl.question('', (s) => {
  const b = s.split('').reduce((acc, curr) => {

    if (Object.hasOwn(dict, curr)) {
      if (acc[curr]) {
        acc[curr] += 1
      } else {
        acc[curr] = 1
      }
    }


    return acc
  }, {})

  b.f = b.f / 2

  console.log(Math.floor(Math.min(...Object.values(b))))
})