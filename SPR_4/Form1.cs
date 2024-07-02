namespace SPR_4;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        int year = (int)numericUpDownYear.Value;
        int count = (int)numericUpDownCount.Value; //А тонн
        int yearDown = (int)numericUpDownYearDown.Value; //В тонн
        int minCount = (int)numericUpDownMinCount.Value; //С тонн
        double yearUp = 0.15;
        double up;
        double down;

        for (int i = 1; count > minCount; i++, year++)
        {

            dataGridView1.Rows.Add(year, count, " ", " ", " ");
            up = count * yearUp;
            dataGridView1.Rows.Add(year, " ", "+" + (int)up, " ", " ");
            count += (int)up;
            dataGridView1.Rows.Add(year, " ", " ", count - minCount, " ");

            down = count - yearDown;
            dataGridView1.Rows.Add(year, " ", "-" + (int)yearDown, " ", " ");
            count -= (int)yearDown;
            dataGridView1.Rows.Add(year, " ", " ", count - minCount, " ");

            if (count > minCount)
            {
                dataGridView1.Rows.Add(year, count, " ", " ", "+");
            }
            else
            {
                dataGridView1.Rows.Add(year, count, " ", " ", "-");
            }
        }
    }
}