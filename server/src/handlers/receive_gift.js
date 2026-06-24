const { TikTokLiveConnection, WebcastEvent } = require("tiktok-live-connector");

const tiktokConnection = require("../connections/tiktok");

const sendToUnity = require("./send_to_unity");

const constants = require("../untils/constants");
const giftConfig = require("../untils/gift_config");
// console.log(giftConfig);

const allId = giftConfig.map((gift) => gift.id);
// console.log(allId);

tiktokConnection.on(WebcastEvent.GIFT, (data) => {
  // console.log(data);
  console.log(`${data?.giftDetails?.giftName} x${data.repeatCount}, ${data.test}`);

  const index = allId.indexOf(data.giftId);
  if (index === -1) {
    console.log(`Gift ID ${data.giftId} not found in giftConfig.`);
    return;
  }

  const giftInfo = { ...giftConfig[index] };

  sendToUnity({ ...giftInfo, count: data.test ? 2 : data.repeatCount });
});
