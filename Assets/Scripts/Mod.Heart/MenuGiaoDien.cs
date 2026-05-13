namespace Mod.Heart
{
    public class MenuGiaoDien
    {
    	public static string[] menuMod = new string[7] {"Thông Báo Boss", "Danh sách nhân vật", "Địa hình lưới", "Danh sách SKH", "Thông tin up vàng", "Thông tin sư phụ", "Auto Giải Capcha"};

    	public static bool[] getArrMod()
    	{
    		return new bool[7]
    		{
    			DoHoa.isHuntingBoss,
    			DoHoa.isShowCharsInMap,
    			DoHoa.MapLuoi,
    			ModHeartPro.hienThiDoKH,
    			MainMod.infoTrainGold,
    			ModHeartPro.charw,
    			MainMod.AutoCapCha
    		};
    	}
    }
}
