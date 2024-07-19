package org.openjfx;


import java.io.*;

public class ServiceForCalculatePassing {

    private String pathToCSV;
    private String pathToResults;
    private double percentStageFromProfile;
    private double percentOfTheProfileForTest;
    private double stabLoadStage;
    private double rampUp;
    private double rampUpForFirstStageInSec;

    public String calculate() {
        File results = new File(pathToResults.concat("results.txt"));

        try {
            results.createNewFile();
        } catch (Exception e) {
            System.out.println(e.getMessage() + ": " + pathToResults);
            results = new File("results.txt");
        }

        try (BufferedReader br = new BufferedReader(new FileReader(pathToCSV));
             FileWriter fw = new FileWriter(results, true))
        {
            while (br.ready()) {
                String line = br.readLine();
                if (!line.startsWith("UC")) {
                    continue;
                }

                //[0 - UCName, 1 - DurationUC, 2 - IntensityUC]
                String[] tokens = line.split(",");
                String UCName = tokens[0];
                double durationUC = Double.parseDouble(tokens[1]);
                double intensityUC = Double.parseDouble(tokens[2]);

                //оп/ч на 1 Vu
                double opInHourPerVU = 3600 / durationUC;

                //Кол-во Vu для нагрузки
                double countVUForTesting = Math.ceil(intensityUC / opInHourPerVU);

                //Кол-во операций на 1 Vu в час
                double opInHourPerVUForTest = intensityUC / countVUForTesting;

                //passing LR в секундах
                double passingLRInSec = 3600 / opInHourPerVUForTest;

                //Кол-во операций на 1 пользователя в минуту
                double opInMinutesPerVU = 3600 / opInHourPerVUForTest;

                //Кол-во пользователей для эмуляции шага нагрузки
                double VUUpPerStage = countVUForTesting * (percentStageFromProfile / 100);

                //Кол-во ступеней в тесте
                double numberOfStages = ((percentOfTheProfileForTest - 100) / percentStageFromProfile) + 1;

                //Длительность всего теста
                double testDurationInSec = rampUpForFirstStageInSec + stabLoadStage + ((numberOfStages - 1) * (rampUp + stabLoadStage));

                fw.write("Название теста: " + UCName +
                        "; Длительность теста: " + durationUC +
                        "; Интенсивность теста: " + intensityUC +
                        "\n\t Операций в час на Vu (не для теста): " + opInHourPerVU +
                        "\n\t Кол-во Vu для теста: " + countVUForTesting +
                        "\n\t Операций в час на Vu (для теста): " + opInHourPerVUForTest +
                        "\n\t (LoadRunner) Passing для LR: " + passingLRInSec +
                        "\n\t операций в минуту на Vu: " + opInMinutesPerVU +
                        "\n\t Кол-во новых Vu на новой ступени: " + VUUpPerStage +
                        "\n\t Ramp-up Для первой ступени: " + rampUpForFirstStageInSec +
                        "\n\t Ramp-up для остальных ступеней: " + rampUp +
                        "\n\t Кол-во ступеней: " + numberOfStages +
                        "\n\t Длительность ступени: " + stabLoadStage +
                        "\n\t Длительность всего теста: " + testDurationInSec +
                        "\n-----------FOR JMETER-----------\n");

                double tempInitialDelay = 0;
                double tempHoldLoadFor = 0;
                double tempRampUp = rampUpForFirstStageInSec;
                int percentProfile = 100;
                for (int i = 1; i <= numberOfStages; i++) {
                    if (i == 1) {
                        tempHoldLoadFor = testDurationInSec - rampUpForFirstStageInSec;
                    } else if (i == 2) {
                        percentProfile += (int) percentStageFromProfile;
                        tempInitialDelay = tempInitialDelay + stabLoadStage + rampUpForFirstStageInSec;
                        tempHoldLoadFor = tempHoldLoadFor - (stabLoadStage + rampUp);
                        tempRampUp = rampUp;
                    } else {
                        percentProfile += (int) percentStageFromProfile;
                        tempInitialDelay = tempInitialDelay + stabLoadStage + rampUp;
                        tempHoldLoadFor = tempHoldLoadFor - (stabLoadStage + rampUp);
                    }

                    fw.write("Stage " + i + ":" +
                            "\n\t initial delay: " + tempInitialDelay +
                            "\n\t startup time: " + tempRampUp +
                            "\n\t hold load for: " + tempHoldLoadFor +
                            "\n\t Процент от профиля: " + percentProfile + "%");
                    fw.write("\n");
                    fw.flush();
                }
                fw.write("\n\n");
                fw.flush();
            }
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return results.getAbsolutePath();
    }

    public String getPathToCSV() {
        return pathToCSV;
    }

    public void setPathToCSV(String pathToCSV) {
        this.pathToCSV = pathToCSV;
    }

    public String getPathToResults() {
        return pathToResults;
    }

    public void setPathToResults(String pathToResults) {
        this.pathToResults = pathToResults;
    }

    public double getPercentStageFromProfile() {
        return percentStageFromProfile;
    }

    public void setPercentStageFromProfile(double percentStageFromProfile) {
        this.percentStageFromProfile = percentStageFromProfile;
    }

    public double getPercentOfTheProfileForTest() {
        return percentOfTheProfileForTest;
    }

    public void setPercentOfTheProfileForTest(double percentOfTheProfileForTest) {
        this.percentOfTheProfileForTest = percentOfTheProfileForTest;
    }

    public double getStabLoadStage() {
        return stabLoadStage;
    }

    public void setStabLoadStage(double stabLoadStage) {
        this.stabLoadStage = stabLoadStage;
    }

    public double getRampUp() {
        return rampUp;
    }

    public void setRampUp(double rampUp) {
        this.rampUp = rampUp;
    }

    public double getRampUpForFirstStageInSec() {
        return rampUpForFirstStageInSec;
    }

    public void setRampUpForFirstStageInSec(double rampUpForFirstStageInSec) {
        this.rampUpForFirstStageInSec = rampUpForFirstStageInSec;
    }
}

