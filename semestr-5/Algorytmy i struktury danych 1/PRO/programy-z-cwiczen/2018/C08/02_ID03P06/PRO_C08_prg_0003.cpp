#include <iostream>
using std::cout;
using std::cin;
using std::endl;
using std::string;
using std::ostream;
using std::istream;
///**************************************************************************************
///**************************************************************************************
class MyApplication{
    public:
        void Main01();
        void Main02();
        void Main03();
    };
///**************************************************************************************
///**************************************************************************************
class Candy{
    public:
        Candy(int, int);
        int GetSugar();
        int GetFat();
        Candy operator+(const Candy& )const;
    private:
        int sugar;
        int fat;
friend ostream& operator<<(ostream&, const Candy&);
    };
///**************************************************************************************
///**************************************************************************************
class Box{
    public:
        Box(Candy, Candy);
        Candy GetCoco();
        Candy GetSugar();
        Box operator+(const Box& )const;
    private:
        Candy coco;
        Candy sugar;
friend ostream& operator<<(ostream&, const Box&);
    };
///**************************************************************************************
///**************************************************************************************
class Trunk{
    public:
        Trunk(Box, Box);
        Box GetRose();
        Box GetLily();
        Trunk operator+(const Trunk&)const;
    private:
        Box rose;
        Box lily;
friend ostream& operator<<(ostream&, const Trunk&);
    };
///5,6,7
///**************************************************************************************
///**************************************************************************************
Candy::Candy(int psugar, int pfat): sugar(psugar), fat(pfat){}
///**************************************************************************************
int Candy::GetSugar(){return sugar;}
///**************************************************************************************
int Candy::GetFat(){return fat;}
///**************************************************************************************
Candy Candy::operator+(const Candy& candy)const{
    return Candy(sugar+candy.sugar, fat + candy.fat);
    }
///**************************************************************************************
ostream& operator<<(ostream& s, const Candy& candy){
    s<<"("<<candy.sugar<<", "<<candy.fat<<")";
    return s;
    }
///**************************************************************************************
///**************************************************************************************
Box::Box(Candy pcoco, Candy psugar):coco(pcoco), sugar(psugar){}
///**************************************************************************************
Candy Box::GetCoco(){return coco;}
///**************************************************************************************
Candy Box::GetSugar(){return sugar;}
///**************************************************************************************
Box Box::operator+(const Box& box)const{
return Box(coco+box.coco, sugar + box.sugar);
}
///**************************************************************************************
ostream& operator<<(ostream& s, const Box& box){
    s<<"["<<box.coco<<", "<<box.sugar<<"]";
    return s;
    }
///**************************************************************************************
///**************************************************************************************
Trunk::Trunk(Box prose, Box plily):rose(prose), lily(plily){}
///**************************************************************************************
Box Trunk::GetRose(){return rose;}
///**************************************************************************************
Box Trunk::GetLily(){return lily;}
///**************************************************************************************
Trunk Trunk::operator+(const Trunk& trunk)const{
return Trunk(rose + trunk.rose, lily + trunk.lily);
}
///**************************************************************************************
ostream& operator<<(ostream& s, const Trunk& trunk){
    s<<"{"<<trunk.rose<<", "<<trunk.lily<<"}";
    return s;
    }
///**************************************************************************************
///**************************************************************************************
int main(){
    (new MyApplication)->Main03();
    return 0;
    }
///**************************************************************************************
///**************************************************************************************
void MyApplication::Main01(){
    Candy myC01(3,4);
    cout<<myC01<<endl;
    cout<<"sugar = "<<myC01.GetSugar()<<endl;
    cout<<myC01 + myC01<<endl;
    }
///**************************************************************************************
void MyApplication::Main02(){
    Box box01(Candy(1,2),Candy(3,4));
    cout<<box01+box01<<endl;
    cout<<"coco sugar ="<<box01.GetCoco().GetSugar()<<endl;
    cout<<"sugar sugar ="<<box01.GetSugar().GetSugar()<<endl;
    }
///**************************************************************************************
///**************************************************************************************
void MyApplication::Main03(){
    Trunk trunk(Box(Candy(1,2),Candy(3,4)),Box(Candy(5,6),Candy(7,8)));
    cout<<trunk + trunk<<endl;
    cout<<"rose coco sugar ="<<trunk.GetRose().GetCoco().GetSugar()<<endl;
    }
