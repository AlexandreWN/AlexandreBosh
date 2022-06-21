using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model;
public class HeroisBatalhas
{
	private List<Batalhas> batalhas = new List<Batalhas>();
	private List<Herois> herois = new List<Herois>();

	public List<Batalhas> getBatalhas()
	{
		return batalhas;
	}
	public void setBatalhas(List<Batalhas> batalhas)
	{
		this.batalhas = batalhas;
	}

	public List<Herois> getHerois()
	{
		return herois;
	}
	public void setHerois(List<Herois> herois)
	{
		this.herois = herois;
	}
}