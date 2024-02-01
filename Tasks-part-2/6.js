const readline = require('readline');

const rl = readline.createInterface({
  input: process.stdin,
  output: process.stdout
});

function search(bandas, a) {
  return bandas.reduce((acc, item) => {
    if (Array.isArray(item)) {
      acc = item.find(e => e.num === a);
    } else if (item.num === a) {
      acc = item;
    }
    return acc;
  }, {});
}
rl.question('', (s1) => {
  const [n, numberOfLinesToRead] = s1.split(' ').map(Number);

  for (let i = 1; i < n; i++) {
    bandas.push({
      num: i,
      connections: 1,
    });
  }

  let linesRead = 0;
  rl.on('line', (input) => {
    linesRead++;

    const [question, a, b = 0] = input.split(' ').map(Number);


    let obj, obj1;
    let bandas = [];


    console.log(bandas);
    console.log(b);


    if (question === 3) {
      console.log(search(bandas, a).connections);
    } else if (question === 2) {
      [obj] = bandas.reduce((acc, item) => {
        if (Array.isArray(item)) {
          if (item.find(e => e.num === a)) acc = item;
        }
        return acc;
      }, []);
      if (obj.find(e => e.num === b)) {
        console.log('YES');
      } else console.log('NO');
    } else if (question === 1) {
      obj = bandas.reduce((acc, item) => {
        if (Array.isArray(item)) {
          if (item.find(e => e.num === a)) acc = item;
        } else if (item.num === a) {
          acc = item;
        }
        return acc;
      }, {});

      if (Array.isArray(obj) && obj.find(e => e.num === b)) {
      } else {
        obj1 = bandas.reduce((acc, item) => {
          if(Array.isArray(item)) {
            if(item.find(e => e.num === b)) acc = item;
          }else if(item.num === b) {
            acc = item;
          }
          return acc;
        }, {})

        console.log(obj);
        console.log(obj1);
        if (Array.isArray(obj) && Array.isArray(obj1)) bandas.push(
            [...obj, ...obj1]);
        else if (Array.isArray(obj) && !Array.isArray(obj1)) bandas.push(
            [...obj, obj1]);
        else if (!Array.isArray(obj) && Array.isArray(obj1)) bandas.push(
            [obj, ...obj1]);
        else if (!Array.isArray(obj) && !Array.isArray(obj1)) bandas.push(
            [obj, obj1]);
        bandas.splice(bandas.indexOf(obj), 1);
        bandas.splice(bandas.indexOf(obj1), 1);
        search(bandas, a).connections++;
        search(bandas, b).connections++;
        console.log(bandas);
      }
    }

    // Проверяем, достигли ли заданного количества строк
    if (linesRead >= numberOfLinesToRead) {
      rl.close();
    }
  });

  rl.on('close', () => {
    console.log('Чтение завершено');
  });
});