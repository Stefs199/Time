var res_X = API.getScreenResolutionMantainRatio().Width;
var res_Y = API.getScreenResolutionMantainRatio().Height;
API.onUpdate.connect(function () {
var phandle = API.getLocalPlayer();
var date = API.getEntitySyncedData(phandle, "dw_date");
var hour = API.getEntitySyncedData(phandle, "dw_hour");
if(date !== null && hour !== null) {
API.drawText(`${date}`, res_X - 150, res_Y - 1035, 0.5, 255, 255, 255, 255, 7, 1, false, true, 0);
API.drawText(`${hour}`, res_X - 150, res_Y - 1015, 1, 255, 255, 255, 255, 7, 1, false, true, 0);
}
});