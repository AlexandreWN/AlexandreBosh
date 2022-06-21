using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Model;

public class Armas
{
    private int id;
    private string name;
	private int IDheroi;

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

	public int getIDHeroi()
	{
		return IDheroi;
	}
    public void setIDHeroi(string IDheroi)
	{
		this.IDheroi = IDheroi;
	}
} 
