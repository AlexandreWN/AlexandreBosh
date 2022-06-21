using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Model;

public class Herois
{
    private int id;
    private string name;

	public int getId()
	{
		return id;
	}
	public void setId(int id)
	{
		this.id = id;
	}

	public string getName()
	{
		return name;
	}
	public void setName(string name)
	{
		this.name = name;
	}
}
