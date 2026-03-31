using System;
//父類別
public class person
{
    public string Name="姓氏";

    //建構子
	public person(string n)
	{
        Name= n;
	}
}
//子類別
public class Student :person
{
    public string stdname="名字";
    //建構子
    public Student(string n):base("陳")
    {
        stdname=Name+n;
    }
}

