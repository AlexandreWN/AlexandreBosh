namespace Model;
public class Batalhas
{
    private int id;
    private string name;
    private string description;
    private string DtInicio;
    private string DtFim;

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

	public string getDescription()
	{
		return description;
	}
	public void setDescription(string description)
	{
		this.description = description;
	}

	public string getDtInicio()
	{
		return DtInicio;
	}
	public void setDtInicio(string DtInicio)
	{
		this.DtInicio = DtInicio;
	}

	public string getDtFim()
	{
		return DtFim;
	}
	public void setDtFim(string DtFim)
	{
		this.DtFim = DtFim;
	}
}
