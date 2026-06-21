const randomAttacker = () => {
  const randomNumber = Math.random();
  // console.log(randomNumber);
  return {
    attacker: randomNumber <= 0.5 ? "Ronaldo" : "Messi",
    target: randomNumber <= 0.5 ? "Messi" : "Ronaldo",
  };
};

module.exports = randomAttacker;
