module org.openjfx {
    requires javafx.controls;
    requires javafx.fxml;
    requires javafx.graphics;
    requires java.compiler;
    requires java.desktop;
    requires javafx.base;

    opens org.openjfx to javafx.fxml;
    exports org.openjfx;
}
