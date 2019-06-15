module.exports = function (callback, s) {
  const privateKey = Buffer.from(s, 'hex');
  callback(null, privateKey);
};