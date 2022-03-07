// 
System.Console;

static int Ack(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Ack(m - 1, 1);
    }
    else
    {
        return Ack(m - 1, Ack(m, n - 1));
    }

}
private void button13_Click(object sender, EventArgs e)
{
    int a = int.Parse(textBox24.Text);
    int b = int.Parse(textBox25.Text);
    string eee = Ack(a, b).ToString();
    label50.Text = eee;
}