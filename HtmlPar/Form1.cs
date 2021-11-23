using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace HtmlPar
{
    public partial class Form1 : Form
    {
        Timer timer;
        List<string> cityId;
        public Form1()
        {
            InitializeComponent();
            cityId = new List<string>() { "4944 Киев", "4368 Москва", "5077 Днепр", "4949 Львов", "4982 Одесса", "4079 Санкт-Петербург", "4248 Минкс", "Рига 4136" };     
            cityId.ForEach(x => comboBoxCity.Items.Add(x.Split(' ')[1]));
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            comboBoxCity.SelectedIndex = 0;
        }


        private void UpdateData()
        {
            var node = GisMeteo.UpdateNode();
            labelTime.Text = node.SelectSingleNode("//div[@class='current-time']")?.InnerText.Trim();
            labelZone.Text = node.SelectSingleNode("//a[@class='city-link link']")?.InnerText.Trim();
            labelState.Text = node.SelectSingleNode("//div[@class='weather-description']")?.InnerText.Trim();
            tempLarge.Text = node.SelectSingleNode("//div[@class='temperature']").SelectSingleNode("//span[@class='unit unit_temperature_c']")?.InnerText.Trim().Replace("minus;", "-");
            labelData.Text = "Ощущается как: " + node.SelectSingleNode("//span[@class='unit unit_temperature_c']")?.InnerText.Trim().Replace("minus;", "-") + "C \t" + node.SelectSingleNode("//span[@class='unit unit_temperature_f']").InnerText.Trim().Replace("minus;", "-") + "F";
            labelData.Text += "\n\rВетер: " + node.SelectSingleNode("//span[@class='unit unit_wind_m_s']")?.InnerText.Trim().Replace("&nbsp;", "");
            labelData.Text += "\n\rДавление: " + node.SelectSingleNode("//span[@class='unit unit_pressure_mm_hg_atm']")?.InnerText.Trim().Replace("&nbsp;", "");
            labelData.Text += "\n\rВлажность: " + node.SelectSingleNode("//div[@class='weather-item weather-humidity']")?.SelectSingleNode("div[@class='item-value']")?.InnerText.Trim().Replace("&nbsp;", "");
            labelData.Text += "\n\rГеомагнитическая активность: " + node.SelectSingleNode("//div[@class='weather-item weather-geomagnetic']")?.SelectSingleNode("div[@class='item-value']")?.InnerText.Split("&nbsp;")[0].Replace("&nbsp;", "") + " балл";
            labelData.Text += "\n\rТемпература воды: " + node.SelectSingleNode("//div[@class='weather-item weather-water']").SelectSingleNode("div[@class='item-value']").SelectSingleNode("span[@class='unit unit_temperature_c']")?.InnerText.Trim().Replace("minus;", "-") + "C \t" + node.SelectSingleNode("//div[@class='weather-item weather-water']").SelectSingleNode("div[@class='item-value']").SelectSingleNode("span[@class='unit unit_temperature_f']")?.InnerText.Trim().Replace("minus;", "-") + "F";
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void comboBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxCity.SelectedIndex != -1)
                GisMeteo.id = cityId[comboBoxCity.SelectedIndex].Split(' ')[0];
            UpdateData();
        }
    }
}
