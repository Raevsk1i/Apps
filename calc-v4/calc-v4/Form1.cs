using System;
using System.IO;
using System.Windows.Forms;

namespace calc_v4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MessageError(string message)
        {
            MessageBox.Show(message, null, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MessageResult(string message)
        {
            MessageBox.Show(message);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                string pathToCsv = path_to_CSV.Text.Trim();
                string pathToResults = path_to_results.Text.Trim() + "results.txt";

                int percentProfile = Convert.ToInt32(percent_profile.Text.Trim());
                int firstRampUp = Convert.ToInt32(first_ramp_up.Text.Trim());
                int stageDuration = Convert.ToInt32(stage_duration.Text.Trim());
                int rampUp = Convert.ToInt32(ramp_up.Text.Trim());
                int percentStage = Convert.ToInt32(percent_stage.Text);

                FileInfo results = new FileInfo(pathToResults);
                FileInfo profile = new FileInfo(pathToCsv);

                if (profile.Exists)
                {
                    StreamReader reader = profile.OpenText();
                    StreamWriter writer = results.CreateText();
                    writer.AutoFlush = true;
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        //index 0 - test_name,
                        //index 1 - test_duration,
                        //index 2 - intensity
                        string[] testInfo = line.Split(',');
                        string UCName = testInfo[0];
                        double durationUC = Convert.ToDouble(testInfo[1]);
                        double intensityUC = Convert.ToDouble(testInfo[2]);

                        //оп/ч на 1 Vu
                        double opInHourPerVU = 3600 / durationUC;

                        //Кол-во Vu для нагрузки
                        double countVUForTesting = Math.Ceiling(intensityUC / opInHourPerVU);

                        //Кол-во операций на 1 Vu в час
                        double opInHourPerVUForTest = intensityUC / countVUForTesting;

                        //passing LR в секундах
                        double pacingLRInSec = 3600 / opInHourPerVUForTest;

                        //Кол-во операций на 1 пользователя в минуту
                        double opInMinutesPerVU = 3600 / opInHourPerVUForTest;

                        //Кол-во пользователей для эмуляции шага нагрузки
                        double VUUpPerStage = countVUForTesting * (percentStage / 100.00);

                        //Кол-во ступеней в тесте
                        double numberOfStages = ((percentProfile - 100.00) / percentStage) + 1;

                        //Длительность всего теста
                        double testDurationInSec = firstRampUp + stageDuration + ((numberOfStages - 1) * (rampUp + stageDuration));

                        writer.Write($"Название теста: {UCName}, Длительность скрипта: {durationUC}, Интенсивность скрипта: {intensityUC}/час" +
                            $"\n\t Операций в час на VU (Не для теста): {opInHourPerVU}" +
                            $"\n\t Кол-во VU для теста: {countVUForTesting}" +
                            $"\n\t Операций в час на VU (Для теста): {opInHourPerVUForTest}" +
                            $"\n\t (LoadRunner) Pacing для LR: {pacingLRInSec}" +
                            $"\n\t Операций в минуту на VU: {opInMinutesPerVU}" +
                            $"\n\t Кол-во новых Vu на новой ступени: {VUUpPerStage}" +
                            $"\n\t Ramp-up Для первой ступени: {firstRampUp}" +
                            $"\n\t Ramp-up для остальных ступеней: {rampUp}" +
                            $"\n\t Кол-во ступеней: {numberOfStages}" +
                            $"\n\t Длительность ступени: {stageDuration}" +
                            $"\n\t Длительность всего теста: {testDurationInSec}" +
                            $"\n-------------------FOR-JMETER--------------------\n");

                        double tempInitialDelay = 0;
                        double tempHoldLoadFor = 0;
                        double tempRampUp = firstRampUp;
                        int countPercentProfile = 100;

                        for (int i = 1; i <= numberOfStages; i++)
                        {
                            if (i == 1)
                            {
                                tempHoldLoadFor = testDurationInSec - firstRampUp;
                            } else if (i == 2)
                            {
                                countPercentProfile += percentStage;
                                tempInitialDelay = tempInitialDelay + stageDuration + firstRampUp;
                                tempHoldLoadFor = tempHoldLoadFor - (stageDuration + rampUp);
                                tempRampUp = rampUp;
                            } else
                            {
                                countPercentProfile += percentStage;
                                tempInitialDelay = tempInitialDelay + stageDuration + rampUp;
                                tempHoldLoadFor = tempHoldLoadFor - (stageDuration + rampUp);
                            }

                            writer.Write($"Stage: {i}:" +
                                $"\n\t initial delay: {tempInitialDelay}" +
                                $"\n\t startupTime: {tempRampUp}" +
                                $"\n\t hold load for: {tempHoldLoadFor}" +
                                $"\n\t Процент от профиля: {countPercentProfile}%\n");
                        }
                        writer.Write("\n\n");
                    }
                    MessageResult($"Расчеты были сохранены по пути: {pathToResults}");
                    writer.Close();
                    reader.Close();

                }
            } catch (Exception ex)
            {
                MessageError($"Маму любишь? А че тогда хуйню вводишь какую-то?\nВот ошибка, довольствуйся, уебан:\n{ex.ToString()}");
                Console.WriteLine(ex.Message);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
