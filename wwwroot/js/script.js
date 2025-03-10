document.addEventListener('DOMContentLoaded', function () {
    const studentTableBody = document.getElementById('student-table-body');
    const studentTable = document.getElementById('student-table');
    const fetchStudentsButton = document.getElementById('fetch-students-button');
    const fetchStudentButton = document.getElementById('fetch-student-button');
    const studentIdInput = document.getElementById('student-id');
    const addStudentButton = document.getElementById('add-student-button');
    const addStudentModal = document.getElementById('add-student-modal');
    const closeAddModal = document.getElementById('close-add-modal');
    const addStudentForm = document.getElementById('add-student-form');
    const editStudentModal = document.getElementById('edit-student-modal');
    const closeEditModal = document.getElementById('close-edit-modal');
    const editStudentForm = document.getElementById('edit-student-form');
    const editStudentIdInput = document.getElementById('edit-student-id');
    const editStudentNameInput = document.getElementById('edit-student-name');
    const editArtScoreInput = document.getElementById('edit-art-score');

    // 取得所有學生列表
    async function fetchStudents() {
        const response = await fetch('http://localhost:5000/api/Students');
        const data = await response.json();
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
    }

    // 取得單一學生資料
    async function fetchStudentById(studentId) {
        const response = await fetch(`http://localhost:5000/api/Students/${studentId}`);
        const student = await response.json();
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
    }

    // 新增學生
    addStudentForm.addEventListener('submit', async function (event) {
        event.preventDefault();
        const student = {
            name: document.getElementById('student-name').value,
            class_name: document.getElementById('class-name').value,
            art_score: parseInt(document.getElementById('art-score').value)
        };

        const response = await fetch('http://localhost:5000/api/Students', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(student)
        });
        if (response.ok) {
            fetchStudents();
            addStudentForm.reset();
            addStudentModal.style.display = 'none';
        } else {
            console.error('新增學生失敗');
        }
    });

    // 編輯學生
    studentTableBody.addEventListener('click', async function (event) {
        if (event.target.classList.contains('edit-button')) {
            const studentId = event.target.getAttribute('data-id');
            const response = await fetch(`http://localhost:5000/api/Students/${studentId}`);
            const student = await response.json();
            console.log('editStudentIdInput:', editStudentIdInput);
            console.log('editStudentNameInput:', editStudentNameInput);
            console.log('editArtScoreInput:', editArtScoreInput);
            console.log('editStudentModal:', editStudentModal);
            editStudentIdInput.value = student.id;
            editStudentNameInput.value = student.name;
            editArtScoreInput.value = student.art_score;
            window.originalClassName = student.class_name; // 儲存原始值
            editStudentModal.style.display = 'block';
        }
    });

    // 更新學生
    editStudentForm.addEventListener('submit', async function (event) {
        event.preventDefault();
        const studentId = editStudentIdInput.value;
        const student = {
            id: studentId,
            name: editStudentNameInput.value,
            class_name: window.originalClassName, // 使用原始值
            art_score: parseInt(editArtScoreInput.value)
        };

        const response = await fetch(`http://localhost:5000/api/Students/${studentId}`, {
            method: 'PUT',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(student)
        });
        if (response.ok) {
            fetchStudents();
            editStudentModal.style.display = 'none';
        } else {
            console.error('更新學生失敗');
        }
    });

    // 刪除學生
    studentTableBody.addEventListener('click', async function (event) {
        if (event.target.classList.contains('delete-button')) {
            const studentId = event.target.getAttribute('data-id');
            const response = await fetch(`http://localhost:5000/api/Students/${studentId}`, {
                method: 'DELETE'
            });
            if (response.ok) {
                fetchStudents();
            } else {
                console.error('刪除學生失敗');
            }
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

    // 顯示新增學生模態對話框
    addStudentButton.addEventListener('click', function () {
        addStudentModal.style.display = 'block';
    });

    // 關閉新增學生模態對話框
    closeAddModal.addEventListener('click', function () {
        addStudentModal.style.display = 'none';
    });

    // 關閉編輯學生模態對話框
    closeEditModal.addEventListener('click', function () {
        editStudentModal.style.display = 'none';
    });

    // 點擊模態對話框外部關閉對話框
    window.addEventListener('click', function (event) {
        if (event.target == addStudentModal) {
            addStudentModal.style.display = 'none';
        }
        if (event.target == editStudentModal) {
            editStudentModal.style.display = 'none';
        }
    });
});