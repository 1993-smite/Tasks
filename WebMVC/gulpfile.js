var gulp = require('gulp'),
    browserSync = require('browser-sync');

gulp.task('browser-sync', function () {
    var files = [
        './**/*.html',
        './wwwroot/css/**/*.css',
        './wwwroot/js/*.js'
    ];

    browserSync.init(files, {
        server: {
            baseDir: './'
        }
    });
});