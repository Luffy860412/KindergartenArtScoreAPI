document.addEventListener('DOMContentLoaded', function () {
    const studentTableBody = document.getElementById('student-table-body');
    const studentTable = document.getElementById('student-table');
    const fetchStudentsButton = document.getElementById('fetch-students-button');
    const fetchStudentButton = document.getElementById('fetch-student-button');
    const studentIdInput = document.getElementById('student-id');
    const addStudentForm = document.getElementById('add-student-form');
    const editStudentForm = document.getElementById('edit-student-form');
    const editStudentContainer = document.getElementById('edit-student-container');
    const editStudentIdInput = document.getElementById('edit-student-id');
    const editStudentNameInput = document.getElementById('edit-student-name');
    const editArtScoreInput = document.getElementById('edit-art-score');

    // 取得所有學生列表
    function fetchStudents() {
        fetch('http://localhost:5000/api/Students')
            .then(response => response.json())
            .then(data => {
                studentTableBody.innerHTML = '';
                data.forEach(student => {
                    const row = document.createElement('tr');
                    row.innerHTML = `
                        <td>${student.id}</td>
                        <td>${student.name}</td>
                        <td>${student.class_name}</td>
                        <td>${student.art_score}</td>
                        <td>
                            <button class="edit-button" data-id="${student.id}">編輯</button>
                            <button class="delete-button" data-id="${student.id}">刪除</button>
                        </td>
                    `;
                    studentTableBody.appendChild(row);
                });
                studentTable.style.display = 'table';
            });
    }

    // 取得單一學生資料
    function fetchStudentById(studentId) {
        fetch(`http://localhost:5000/api/Students/${studentId}`)
            .then(response => response.json())
            .then(student => {
                studentTableBody.innerHTML = '';
                const row = document.createElement('tr');
                row.innerHTML = `
                    <td>${student.id}</td>
                    <td>${student.name}</td>
                    <td>${student.class_name}</td>
                    <td>${student.art_score}</td>
                    <td>
                        <button class="edit-button" data-id="${student.id}">編輯</button>
                        <button class="delete-button" data-id="${student.id}">刪除</button>
                    </td>
                `;
                studentTableBody.appendChild(row);
                studentTable.style.display = 'table';
            });
    }

    // 新增學生
    addStudentForm.addEventListener('submit', function (event) {
        event.preventDefault();
        const formData = new FormData(addStudentForm);
        const student = {
            name: formData.get('student-name'),
            class_name: formData.get('class-name'),
            art_score: formData.get('art-score')
        };

        fetch('http://localhost:5000/api/Students', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(student)
        })
            .then(response => response.json())
            .then(data => {
                fetchStudents();
                addStudentForm.reset();
            });
    });

    // 編輯學生
    studentTableBody.addEventListener('click', function (event) {
        if (event.target.classList.contains('edit-button')) {
            const studentId = event.target.getAttribute('data-id');
            fetch(`http://localhost:5000/api/Students/${studentId}`)
                .then(response => response.json())
                .then(student => {
                    editStudentIdInput.value = student.id;
                    editStudentNameInput.value = student.name;
                    editArtScoreInput.value = student.art_score;
                    editStudentContainer.style.display = 'block';
                });
        }
    });

    // 更新學生
    editStudentForm.addEventListener('submit', function (event) {
        event.preventDefault();
        const studentId = editStudentIdInput.value;
        const student = {
            id: studentId,
            name: editStudentNameInput.value,
            art_score: editArtScoreInput.value
        };

        fetch(`http://localhost:5000/api/Students/${studentId}`, {
            method: 'PUT',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(student)
        })
            .then(response => response.json())
            .then(data => {
                fetchStudents();
                editStudentContainer.style.display = 'none';
            });
    });

    // 刪除學生
    studentTableBody.addEventListener('click', function (event) {
        if (event.target.classList.contains('delete-button')) {
            const studentId = event.target.getAttribute('data-id');
            fetch(`http://localhost:5000/api/Students/${studentId}`, {
                method: 'DELETE'
            })
                .then(response => {
                    fetchStudents();
                });
        }
    });

    // 查詢所有學生資料按鈕
    fetchStudentsButton.addEventListener('click', function () {
        fetchStudents();
    });

    // 查詢單一學生資料按鈕
    fetchStudentButton.addEventListener('click', function () {
        const studentId = studentIdInput.value;
        if (studentId) {
            fetchStudentById(studentId);
        }
    });
});