using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model;
public class IdentidadeSecreta
{
    private int id;
    private string realName;
    private int IDherois;

	public int getId()
	{
		return id;
	}
	public void setId(int id)
	{
		this.id = id;
	}

	public string getRealName()
	{
		return realName;
	}
	public void setRealName(string realName)
	{
		this.realName = realName;
	}

	public int getIDHerois()
	{
		return IDherois;
	}
    public void setIDHerois(string IDheroi)
	{
		this.IDheroi = IDheroi;
	}
}