<?php
// Database connection
$servername = "localhost";
$username = "root";
$password = "";
$dbname = "bike_rental";

// Get RFID from POST
$rfid = isset($_POST['rfid']) ? $_POST['rfid'] : null;

if ($rfid) {
    // Establish database connection
    $conn = new mysqli($servername, $username, $password, $dbname);

    if ($conn->connect_error) {
        die("Connection failed: " . $conn->connect_error);
    }

    // Check if RFID exists in rfid_table
    $stmt = $conn->prepare("SELECT uidtag FROM rfid_table WHERE uidtag = ?");
    $stmt->bind_param("s", $rfid);
    $stmt->execute();
    $result = $stmt->get_result();

    if ($result->num_rows == 0) {
        // First scan: Insert RFID into rfid_table
        $insertStmt = $conn->prepare("INSERT INTO rfid_table (uidtag) VALUES (?)");
        $insertStmt->bind_param("s", $rfid);
        if ($insertStmt->execute()) {
            echo "RFID saved successfully in rfid_table!";
        } else {
            echo "Error saving RFID to rfid_table: " . $conn->error;
        }
    } else {
        // Second scan: Update return_date_time in bike_details
        $currentDateTime = date('Y-m-d H:i:s');
        $updateStmt = $conn->prepare("UPDATE bike_details SET return_date_time = ? WHERE rfid = ? AND return_date_time IS NULL");
        $updateStmt->bind_param("ss", $currentDateTime, $rfid);
        if ($updateStmt->execute()) {
            if ($updateStmt->affected_rows > 0) {
                echo "Return date/time updated in bike_details successfully!";
            } else {
                echo "No active rental found for this RFID.";
            }
        } else {
            echo "Error updating return_date_time in bike_details: " . $conn->error;
        }
    }

    $conn->close();
} else {
    echo "No RFID received.";
}
?>
