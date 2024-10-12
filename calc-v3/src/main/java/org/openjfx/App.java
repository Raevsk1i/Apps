package org.openjfx;

import javafx.application.Application;
import javafx.geometry.HPos;
import javafx.geometry.Insets;
import javafx.geometry.Pos;
import javafx.scene.Scene;
import javafx.scene.control.Alert;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.control.TextField;
import javafx.scene.layout.ColumnConstraints;
import javafx.scene.layout.GridPane;
import javafx.scene.layout.Priority;
import javafx.scene.text.Font;
import javafx.scene.text.FontWeight;
import javafx.stage.Stage;
import javafx.stage.Window;

import java.io.File;

public class App extends Application {

    private final ServiceForCalculatePassing svc = new ServiceForCalculatePassing();

    @Override
    public void start(Stage primaryStage) throws Exception {
        primaryStage.setTitle("Calculator for LTT");

        // Create the registration form grid pane
        GridPane gridPane = createRegistrationFormPane();
        // Add UI controls to the registration form grid pane
        addUIControls(gridPane);
        // Create a scene with registration form grid pane as the root node
        Scene scene = new Scene(gridPane, 900, 700);
        // Set the scene in primary stage
        primaryStage.setScene(scene);

        primaryStage.show();
    }

    private GridPane createRegistrationFormPane() {
        // Instantiate a new Grid Pane
        GridPane gridPane = new GridPane();

        // Position the pane at the center of the screen, both vertically and horizontally
        gridPane.setAlignment(Pos.CENTER);

        // Set a padding of 20px on each side
        gridPane.setPadding(new Insets(20, 20, 20, 20));

        // Set the horizontal gap between columns
        gridPane.setHgap(20);

        // Set the vertical gap between rows
        gridPane.setVgap(20);

        // Add Column Constraints

        // columnOneConstraints will be applied to all the nodes placed in column one.
        ColumnConstraints columnOneConstraints = new ColumnConstraints(149, 120, Double.MAX_VALUE);
        columnOneConstraints.setHalignment(HPos.RIGHT);

        // columnTwoConstraints will be applied to all the nodes placed in column two.
        ColumnConstraints columnTwoConstrains = new ColumnConstraints(200,200, Double.MAX_VALUE);
        columnTwoConstrains.setHgrow(Priority.ALWAYS);

        gridPane.getColumnConstraints().addAll(columnOneConstraints, columnTwoConstrains);

        return gridPane;
    }

    private void addUIControls(GridPane gridPane) {
        // Add Header
        Label headerLabel = new Label("Регистрация конфига");
        headerLabel.setFont(Font.font("Arial", FontWeight.BOLD, 24));
        gridPane.add(headerLabel, 0,0,2,1);
        GridPane.setHalignment(headerLabel, HPos.CENTER);
        GridPane.setMargin(headerLabel, new Insets(20, 0,20,0));

        // Add Path CSV Label
        Label pathToCSVLabel = new Label("Путь до csv : ");
        gridPane.add(pathToCSVLabel, 0,1);

        // Add Path CSV Text Field
        TextField pathToCSVField = new TextField();
        pathToCSVField.setPrefHeight(30);
        gridPane.add(pathToCSVField, 1,1);

        // Add Path Results Label
        Label pathToResultsLabel = new Label("Куда сохранить резы : ");
        gridPane.add(pathToResultsLabel, 0,2);

        // Add Path Results Text Field
        TextField pathToResultsField = new TextField();
        pathToResultsField.setPrefHeight(30);
        gridPane.add(pathToResultsField, 1,2);

        // Add Load Stages Percent Label
        Label percentLoadStagesLabel = new Label("% ступени : ");
        gridPane.add(percentLoadStagesLabel, 0, 3);

        // Add Load Stages Percent Text Field
        TextField percentLoadStagesField = new TextField();
        percentLoadStagesField.setPrefHeight(30);
        gridPane.add(percentLoadStagesField, 1, 3);

        // Add Time Stabilization For Load Stage Label
        Label stabLoadStageLabel = new Label("sec Время ступени : ");
        gridPane.add(stabLoadStageLabel, 0, 4);

        // Add Time Stabilization For Load Stage Field
        TextField stabLoadStageField = new TextField();
        stabLoadStageField.setPrefHeight(30);
        gridPane.add(stabLoadStageField, 1, 4);

        // Add First Ramp-up Label
        Label firstRampUpLabel = new Label("sec Первый Ramp-up : ");
        gridPane.add(firstRampUpLabel, 0, 5);

        // Add First Ramp-up Field
        TextField firstRampUpField = new TextField();
        firstRampUpField.setPrefHeight(30);
        gridPane.add(firstRampUpField, 1, 5);

        // Add Ramp-up Period For Load Stage Label
        Label rampUpLabel = new Label("sec Ramp-Up : ");
        gridPane.add(rampUpLabel, 0, 6);

        // Add Ramp-up Period For Load Stage Field
        TextField rampUpField = new TextField();
        rampUpField.setPrefHeight(30);
        gridPane.add(rampUpField, 1, 6);

        // Add Profile Label
        Label profileLabel = new Label("% профиля : ");
        gridPane.add(profileLabel, 0, 7);

        // Add Profile Field
        TextField profileField = new TextField();
        profileField.setPrefHeight(30);
        gridPane.add(profileField, 1, 7);

        // Add Submit Button
        Button submitButton = new Button("Подтвердить");
        submitButton.setPrefHeight(30);
        submitButton.setDefaultButton(true);
        submitButton.setPrefWidth(100);
        gridPane.add(submitButton, 0, 8, 2, 1);
        GridPane.setHalignment(submitButton, HPos.CENTER);
        GridPane.setMargin(submitButton, new Insets(20, 0,20,0));

        Label descLabel = new Label("% профиля - процент от профиля, до которого поднимаем нагрузку \n" +
                "sec Время ступени - время стабилизации нагрузки на ступени\n" +
                "% ступени -  от профиля, на который ступень поднимает нагрузку\n" +
                "Путь до результатов, пример: C:\\files\\calc\\" +
                "\nRamp-up - это рамп-ап для всех, кроме первой ступени."
        );
        gridPane.add(descLabel, 1, 9);

        submitButton.setOnAction(actionEvent ->  {
            File file = new File(pathToCSVField.getText());
            if (pathToCSVField.getText().isEmpty() || !file.exists()) {
                showAlert(Alert.AlertType.ERROR, gridPane.getScene().getWindow(), "Form Error!", "Введите путь к csv файлу");
                return;
            } else {
                svc.setPathToCSV(pathToCSVField.getText());
            }
            if (pathToResultsField.getText().isEmpty() || !file.exists()) {
                showAlert(Alert.AlertType.ERROR, gridPane.getScene().getWindow(), "Form Error!", "Введите путь к результатам");
                return;
            } else {
                svc.setPathToResults(pathToResultsField.getText());
            }
            if (percentLoadStagesField.getText().isEmpty()) {
                showAlert(Alert.AlertType.ERROR, gridPane.getScene().getWindow(), "Form Error!", "Введите процент ступени");
                return;
            } else {
                svc.setPercentStageFromProfile(Double.parseDouble(percentLoadStagesField.getText()));
            }
            if (stabLoadStageField.getText().isEmpty()) {
                showAlert(Alert.AlertType.ERROR, gridPane.getScene().getWindow(), "Form Error!", "Введите время ступени");
                return;
            } else {
                svc.setStabLoadStage(Double.parseDouble(stabLoadStageField.getText()));
            }
            if (firstRampUpField.getText().isEmpty()) {
                showAlert(Alert.AlertType.ERROR, gridPane.getScene().getWindow(), "Form Error!", "Введите время первого Ramp-up");
                return;
            } else {
                svc.setRampUpForFirstStageInSec(Double.parseDouble(firstRampUpField.getText()));
            }
            if (rampUpField.getText().isEmpty()) {
                showAlert(Alert.AlertType.ERROR, gridPane.getScene().getWindow(), "Form Error!", "Введите Ramp-up");
                return;
            } else {
                svc.setRampUp(Double.parseDouble(rampUpField.getText()));
            }
            if (profileField.getText().isEmpty()) {
                showAlert(Alert.AlertType.ERROR, gridPane.getScene().getWindow(), "Form Error!", "Введите используемый процент профиля");
                return;
            } else {
                svc.setPercentOfTheProfileForTest(Double.parseDouble(profileField.getText()));
            }

            String pathToResults = svc.calculate();
            showAlert(Alert.AlertType.CONFIRMATION, gridPane.getScene().getWindow(), "Calculate successful!",
                    "Результаты находятся по пути: " + pathToResults);
        });
    }

    private void showAlert(Alert.AlertType alertType, Window owner, String title, String message) {
        Alert alert = new Alert(alertType);
        alert.setHeight(200);
        alert.setWidth(600);
        alert.setTitle(title);
        alert.setHeaderText(null);
        alert.setContentText(message);
        alert.initOwner(owner);
        alert.show();
    }

    public static void main(String[] args) {
        launch(args);
    }
}