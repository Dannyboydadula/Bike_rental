<?php
// Database connection
$servername = "localhost";
$username = "root";
$password = "";
$dbname = "bike_rental";

// Get RFID from POST
$rfid = isset($_POST['rfid']) ? $_POST['rfid'] : null;

if ($rfid) {
    // Connect to database
    $conn = new mysqli($servername, $username, $password, $dbname);

    if ($conn->connect_error) {
        die("Connection failed: " . $conn->connect_error);
    }

    // Use prepared statements to prevent SQL injection
    $stmt = $conn->prepare("SELECT id FROM bike_details WHERE rfid = ? AND return_date_time IS NULL");
    $stmt->bind_param("s", $rfid);
    $stmt->execute();
    $result = $stmt->get_result();

    if ($result->num_rows > 0) {
        // If the bike is currently rented, update return_date_time
        $updateStmt = $conn->prepare("UPDATE bike_details SET return_date_time = NOW() WHERE rfid = ? AND return_date_time IS NULL");
        $updateStmt->bind_param("s", $rfid);
        if ($updateStmt->execute()) {
            echo "Bike return recorded successfully!";
        } else {
            echo "Error updating return date: " . $conn->error;
        }
    } else {
        // If the bike is not rented, insert a new rental record
        $insertStmt = $conn->prepare("INSERT INTO bike_details (rfid) VALUES (?)");
        $insertStmt->bind_param("s", $rfid);
        if ($insertStmt->execute()) {
            echo "Bike rental recorded successfully!";
        } else {
            echo "Error inserting new rental: " . $conn->error;
        }
    }

    // Close the database connection
    $conn->close();
} else {
    echo "RFID not received.";
}
?>
