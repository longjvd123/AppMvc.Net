using APP.Models;

namespace APP.Services
{
    public class PlanetServices : List<PlanetModel>
    {
        public PlanetServices()
        {
            Add(new PlanetModel(){
                Id=1,
                Name="Mercury",
                VnName="Sao Thủy",
                Content="Sao Thủy (cách Mặt Trời khoảng 0,4 AU) là hành tinh gần Mặt Trời nhất và là hành tinh nhỏ nhất trong Hệ Mặt Trời (0,055 lần khối lượng Trái Đất). Sao Thủy không có vệ tinh tự nhiên, và nó chỉ có các đặc trưng địa chất bên cạnh các hố va chạm đó là các sườn và vách núi, có lẽ được hình thành trong giai đoạn co lại đầu tiên trong lịch sử của nó.[39] Sao Thủy hầu như không có khí quyển do các nguyên tử trong bầu khí quyển của nó đã bị gió Mặt Trời thổi bay ra ngoài không gian.[40] Hành tinh này có lõi sắt tương đối lớn và lớp phủ khá mỏng mà vẫn chưa được các nhà thiên văn giải thích được một cách đầy đủ. Có giả thuyết cho rằng lớp phủ bên ngoài đã bị tước đi sau 1 vụ va chạm khổng lồ, và quá trình bồi tụ vật chất của Sao Thủy bị ngăn chặn bởi năng lượng của Mặt Trời trẻ."
            });

            Add(new PlanetModel(){
                Id=2,
                Name="Venus",
                VnName="Sao Kim",
                Content="Sao Kim (cách Mặt Trời khoảng 0,7 AU) có kích cỡ khá gần với kích thước Trái Đất (với khối lượng bằng 0,815 lần khối lượng Trái Đất) và đặc điểm cấu tạo giống Trái Đất, nó có 1 lớp phủ silicat dày bao quanh 1 lõi sắt"
            });

            Add(new PlanetModel(){
                Id=3,
                Name="Earth",
                VnName="Trái Đất",
                Content="Trái Đất (cách Mặt Trời 1 AU) là hành tinh lớn nhất và có mật độ lớn nhất trong số các hành tinh vòng trong, cũng là hành tinh duy nhất mà chúng ta biết còn có các hoạt động địa chất gần đây, và là hành tinh duy nhất trong vũ trụ được biết đến là nơi có sự sống tồn tại"
            });

            Add(new PlanetModel(){
                Id=4,
                Name="Mars",
                VnName="Sao Hỏa",
                Content="Sao Hỏa (cách Mặt Trời khoảng 1,5 AU) có kích thước nhỏ hơn Trái Đất và Sao Kim (khối lượng bằng 0,107 lần khối lượng Trái Đất)."
            });

            Add(new PlanetModel(){
                Id=5,
                Name="Jupiter",
                VnName="Sao Mộc ",
                Content="Sao Mộc (khoảng cách đến Mặt Trời 5,2 AU), với khối lượng bằng 318 lần khối lượng Trái Đất và bằng 2,5 lần tổng khối lượng của 7 hành tinh còn lại trong Thái Dương Hệ. Mộc Tinh có thành phần chủ yếu hiđrô và heli. Nhiệt lượng khổng lồ từ bên trong Sao Mộc tạo ra một số đặc trưng bán vĩnh cửu trong bầu khí quyển của nó, như các dải mây và Vết đỏ lớn."
            });
            Add(new PlanetModel(){
                Id=6,
                Name="Saturn",
                VnName="Sao Thổ ",
                Content="Sao Thổ (khoảng cách đến Mặt Trời 9,5 AU), có đặc trưng khác biệt rõ rệt đó là hệ vành đai kích thước rất lớn, và những đặc điểm giống với Sao Mộc, như về thành phần bầu khí quyển và từ quyển."
            });
            Add(new PlanetModel(){
                Id=7,
                Name="Uranus",
                VnName="Sao Thiên Vương",
                Content="Sao Thiên Vương (khoảng cách đến Mặt Trời 19,6 AU), khối lượng bằng 14 lần khối lượng Trái Đất, là hành tinh vòng ngoài nhẹ nhất. Trục tự quay của nó có đặc trưng lạ thường duy nhất so với các hành tinh khác, độ nghiêng trục quay >900 so với mặt phẳng hoàng đạo. Thiên Vương Tinh có lõi lạnh hơn nhiều so với các hành tinh khí khổng lồ khác và nhiệt lượng bức xạ vào không gian cũng nhỏ."
            });
            Add(new PlanetModel(){
                Id=8,
                Name="Neptune",
                VnName="Sao Hải Vương",
                Content="Sao Hải Vương (khoảng cách đến Mặt Trời 30 AU), mặc dù kích cỡ hơi nhỏ hơn Sao Thiên Vương nhưng khối lượng của nó lại lớn hơn (bằng 17 lần khối lượng của Trái Đất) và do vậy khối lượng riêng lớn hơn. Nó cũng bức xạ nhiều nhiệt lượng hơn nhưng không lớn bằng của Sao Mộc hay Sao Thổ."
            });
        }
    }
}