class Gift {
  constructor(order, id, giftName, attacker, target, damage, from, to, diamondCount, isRandom = false) {
    this.order = order;
    this.id = id;
    this.name = giftName;
    this.attacker = attacker;
    this.target = target;
    this.damage = damage;
    this.from = from;
    this.to = to;
    this.diamondCount = diamondCount;
    this.isRandom = isRandom;
  }
}

const giftConfig = [
  new Gift(1, 5655, "Gift 1", "ronaldo", "messi", 0.01, 0, 0, 1),
  new Gift(2, 6064, "Gift 2", "ronaldo", "messi", 0.01, 0, 0, 1),
  new Gift(3, 37, "Gift 3", "ronaldo", "messi", 0.1, 0, 0, 5),
  new Gift(4, 8913, "Gift 4", "ronaldo", "messi", 0.25, 0, 0, 10),
  new Gift(5, 5879, "Gift 5", "ronaldo", "messi", 0.4, 0, 0, 30),
  new Gift(6, 5585, "Gift 6", "ronaldo", "messi", 3, 0, 0, 100),
  new Gift(7, 12356, "Gift 7", "ronaldo", "messi", 0, 0.15, 0.2, 9, true),

  new Gift(8, 5760, "Gift 8", "messi", "ronaldo", 0.01, 0, 0, 1),
  new Gift(9, 5269, "Gift 9", "messi", "ronaldo", 0.01, 0, 0, 1),
  new Gift(10, 5487, "Gift 10", "messi", "ronaldo", 0.1, 0, 0, 5),
  new Gift(11, 5853, "Gift 11", "messi", "ronaldo", 0.25, 0, 0, 10),
  new Gift(12, 5492, "Gift 12", "messi", "ronaldo", 0.4, 0, 0, 30),
  new Gift(13, 7264, "Gift 13", "messi", "ronaldo", 3, 0, 0, 100),
  new Gift(14, 8243, "Gift 14", "messi", "ronaldo", 0, 0.15, 0.2, 9, true),

  new Gift(15, 9139, "Gift 15", "random", 0, 0.01, 0.08, 2, true),
];

module.exports = giftConfig;
