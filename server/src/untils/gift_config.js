class Gift {
  constructor(order, id, giftName, attacker, target, damage, from, to, diamondCount) {
    this.order = order;
    this.id = id;
    this.name = giftName;
    this.attacker = attacker;
    this.target = target;
    this.damage = damage;
    this.from = from;
    this.to = to;
    this.diamondCount = diamondCount;
  }
}

const giftConfig = [
  // ronaldo attacks messi
  new Gift(1, 5655, "Gift 1", "Ronaldo", "Messi", 0.01, 0, 0, 1),
  new Gift(2, 6064, "Gift 2", "Ronaldo", "Messi", 0.01, 0, 0, 1),
  new Gift(3, 37, "Gift 3", "Ronaldo", "Messi", 0.1, 0, 0, 5),
  new Gift(4, 8913, "Gift 4", "Ronaldo", "Messi", 0.25, 0, 0, 10),
  new Gift(5, 5879, "Gift 5", "Ronaldo", "Messi", 0.4, 0, 0, 30),
  new Gift(6, 5585, "Gift 6", "Ronaldo", "Messi", 3, 0, 0, 100),
  new Gift(7, 12356, "Gift 7", "Ronaldo", "Messi", 0, 0.15, 0.2, 9),

  // messi attacks ronaldo
  new Gift(8, 5760, "Gift 8", "Messi", "Ronaldo", 0.01, 0, 0, 1),
  new Gift(9, 5269, "Gift 9", "Messi", "Ronaldo", 0.01, 0, 0, 1),
  new Gift(10, 5487, "Gift 10", "Messi", "Ronaldo", 0.1, 0, 0, 5),
  new Gift(11, 5853, "Gift 11", "Messi", "Ronaldo", 0.25, 0, 0, 10),
  new Gift(12, 5492, "Gift 12", "Messi", "Ronaldo", 0.4, 0, 0, 30),
  new Gift(13, 7264, "Gift 13", "Messi", "Ronaldo", 3, 0, 0, 100),
  new Gift(14, 8243, "Gift 14", "Messi", "Ronaldo", 0, 0.15, 0.2, 9),

  // random
  new Gift(15, 9139, "Gift 15", "Random", "Random", 0, 0.01, 0.08, 2),
];

module.exports = giftConfig;

/* 
[
  {
    order: 1,
    id: 5655,
    name: 'Gift 1',
    attacker: 'Ronaldo',
    target: 'Messi',
    damage: 0.01,
    from: 0,
    to: 0,
    diamondCount: 1
  },
  {
    order: 2,
    id: 6064,
    name: 'Gift 2',
    attacker: 'Ronaldo',
    target: 'Messi',
    damage: 0.01,
    from: 0,
    to: 0,
    diamondCount: 1
  },
  {
    order: 3,
    id: 37,
    name: 'Gift 3',
    attacker: 'Ronaldo',
    target: 'Messi',
    damage: 0.1,
    from: 0,
    to: 0,
    diamondCount: 5
  },
  {
    order: 4,
    id: 8913,
    name: 'Gift 4',
    attacker: 'Ronaldo',
    target: 'Messi',
    damage: 0.25,
    from: 0,
    to: 0,
    diamondCount: 10
  },
  {
    order: 5,
    id: 5879,
    name: 'Gift 5',
    attacker: 'Ronaldo',
    target: 'Messi',
    damage: 0.4,
    from: 0,
    to: 0,
    diamondCount: 30
  },
  {
    order: 6,
    id: 5585,
    name: 'Gift 6',
    attacker: 'Ronaldo',
    target: 'Messi',
    damage: 3,
    from: 0,
    to: 0,
    diamondCount: 100
  },
  {
    order: 7,
    id: 12356,
    name: 'Gift 7',
    attacker: 'Ronaldo',
    target: 'Messi',
    damage: 0,
    from: 0.15,
    to: 0.2,
    diamondCount: 9
  },
  
  {
    order: 8,
    id: 5760,
    name: 'Gift 8',
    attacker: 'Messi',
    target: 'Ronaldo',
    damage: 0.01,
    from: 0,
    to: 0,
    diamondCount: 1
  },
  {
    order: 9,
    id: 5269,
    name: 'Gift 9',
    attacker: 'Messi',
    target: 'Ronaldo',
    damage: 0.01,
    from: 0,
    to: 0,
    diamondCount: 1
  },
  {
    order: 10,
    id: 5487,
    name: 'Gift 10',
    attacker: 'Messi',
    target: 'Ronaldo',
    damage: 0.1,
    from: 0,
    to: 0,
    diamondCount: 5
  },
  {
    order: 11,
    id: 5853,
    name: 'Gift 11',
    attacker: 'Messi',
    target: 'Ronaldo',
    damage: 0.25,
    from: 0,
    to: 0,
    diamondCount: 10
  },
  {
    order: 12,
    id: 5492,
    name: 'Gift 12',
    attacker: 'Messi',
    target: 'Ronaldo',
    damage: 0.4,
    from: 0,
    to: 0,
    diamondCount: 30
  },
  {
    order: 13,
    id: 7264,
    name: 'Gift 13',
    attacker: 'Messi',
    target: 'Ronaldo',
    damage: 3,
    from: 0,
    to: 0,
    diamondCount: 100
  },
  {
    order: 14,
    id: 8243,
    name: 'Gift 14',
    attacker: 'Messi',
    target: 'Ronaldo',
    damage: 0,
    from: 0.15,
    to: 0.2,
    diamondCount: 9
  },
  {
    order: 15,
    id: 9139,
    name: 'Gift 15',
    attacker: 'Random',
    target: 'Random',
    damage: 0,
    from: 0.01,
    to: 0.08,
    diamondCount: 2
  }
] */
