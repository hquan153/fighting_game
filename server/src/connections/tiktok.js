const { TikTokLiveConnection } = require("tiktok-live-connector");
const readline = require("readline");

const constants = require("../untils/constants");

const tiktokUsername = constants.tiktokUsername;
const tiktokConnection = new TikTokLiveConnection(tiktokUsername);

readline.emitKeypressEvents(process.stdin);
if (process.stdin.isRawMode) {
  process.stdin.setRawMode(true);
}

console.log("r: rose, q: quit");

tiktokConnection
  .connect()
  .then((state) => {
    console.info(`Connected to roomId ${state.roomId}`);
  })
  .catch((err) => {
    console.error("Failed to connect", err);
  });

process.stdin.on("keypress", (str, key) => {
  console.log(key.name);
  if (key.name === "r") {
    tiktokConnection.emit({ id: 5655, count: 1, diamondCount: 1 });
  } else if (key.name === "q") {
    process.exit();
  }
});

module.exports = tiktokConnection;
