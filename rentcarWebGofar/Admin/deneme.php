<?php
echo'

<div class="content container">
<h2 class="page-title">Components -  <span class="fw-semi-bold">Calendar App</span> <small>Draggable access</small></h2>
<div class="row">
    <div class="col-md-8">
        <section class="widget">
            <header>
                <h4>
                    <i class="fa fa-calendar"></i>
                    Calendar
                </h4>
                <div class="actions">
                    <div class="btn-group mr-sm">
                        <button class="btn btn-default" id="calender-prev"><i class="fa fa-angle-left"></i></button>
                        <button class="btn btn-default" id="calender-next"><i class="fa fa-angle-right"></i></button>
                    </div>
                    <button id="today" type="button" class="btn btn-warning mr-sm">
                        Today
                    </button>
                    <div id="calendar-switcher" class="btn-group" data-toggle="buttons">
                        <label class="btn btn-default active">
                            <input type="radio" name="view" value="month" checked> Month
                        </label>
                        <label class="btn btn-default">
                            <input type="radio" name="view" value="agendaWeek"> Week
                        </label>
                        <label class="btn btn-default">
                            <input type="radio" name="view" value="agendaDay"> Day
                        </label>
                    </div>
                </div>
            </header>
            <div class="body">
                <div id="calendar" class="calendar mt-lg"> </div>
            </div>
        </section>
    </div>
    <div class="col-md-4">
        <section class="widget">
            <header>
                <h5>
                    <i class="fa fa-exchange"></i>
                    Draggable events
                </h5>
            </header>
            <div class="body">
                <div id="external-events">
                    <div class="external-event bg-danger" data-event-class="bg-danger text-white"><i class="fa fa-check"></i> Buy this template</div>
                    <div class="external-event bg-warning" data-event-class="bg-warning text-white">Study some Node</div>
                    <div class="external-event bg-success" data-event-class="bg-success text-white">Make a tea</div>
                    <div class="external-event bg-primary" data-event-class="bg-primary text-white"><i class="fa fa-book"></i> Go to school</div>
                    <div class="external-event bg-info" data-event-class="bg-info text-white">Open windows</div>
                </div>
            </div>
        </section>
    </div>
</div>
<div class="modal fade" id="myModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
    <div class="modal-dialog modal-sm">
        <div class="modal-content">
            <div class="modal-header">
                <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                <h4 class="modal-title">Modal title</h4>
            </div>
            <div class="modal-body">
                <p>One fine body…</p>
            </div>
            <div class="modal-footer">
                <button type="button" class="btn btn-default" data-dismiss="modal">OK</button>
            </div>
        </div><!-- /.modal-content -->
    </div><!-- /.modal-dialog -->
</div><!-- /.modal -->

<div class="modal fade" id="edit-modal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
    <div class="modal-dialog modal-sm">
        <div class="modal-content">
            <div class="modal-header">
                <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                <h4 class="modal-title">Modal title</h4>
            </div>
            <div class="modal-body">
                <div class="form-group">
                    <label for="event-name">Event name</label>
                    <input type="text" id="event-name" name="name" class="form-control bg-gray-lighter">
                </div>
            </div>
            <div class="modal-footer">
                <button data-dismiss="modal" class="btn btn-default">Cancel</button>
                <button data-dismiss="modal" id="create-event" class="btn btn-success">OK</button>
            </div>
        </div><!-- /.modal-content -->
    </div><!-- /.modal-dialog -->
</div><!-- /.modal -->
    <footer class="content-footer">
        Light Blue 4.0 Ajax Version - Made by <a href="https://flatlogic.com/" rel="nofollow noopener noreferrer" target="_blank">Flatlogic</a>
    </footer>
</div>
<div class="loader-wrap hiding hide">
    <i class="fa fa-circle-o-notch fa-spin"></i>
</div>
</div>
<!-- common libraries. required for every page-->
<script src="lib/jquery/dist/jquery.min.js"></script>
<script src="lib/jquery-pjax/jquery.pjax.js"></script>
<script src="lib/bootstrap-sass/assets/javascripts/bootstrap.min.js"></script>
<script src="lib/widgster/widgster.js"></script>
<script src="lib/underscore/underscore.js"></script>

<!-- common application js -->
<script src="js/app.js"></script>
<script src="js/settings.js"></script>

<!-- common templates -->
<script type="text/template" id="settings-template">
<div class="setting clearfix">
<div>Sidebar on the</div>
<div id="sidebar-toggle" class="pull-left btn-group" data-toggle="buttons-radio">
    <% onRight = sidebar == "right"%>
    <button type="button" data-value="left" class="btn btn-sm btn-default <%= onRight? "" : "active" %>">Left</button>
    <button type="button" data-value="right" class="btn btn-sm btn-default <%= onRight? "active" : "" %>">Right</button>
</div>
</div>
<div class="setting clearfix">
<div>Sidebar</div>
<div id="display-sidebar-toggle" class="pull-left btn-group" data-toggle="buttons-radio">
    <% display = displaySidebar%>
    <button type="button" data-value="true" class="btn btn-sm btn-default <%= display? "active" : "" %>">Show</button>
    <button type="button" data-value="false" class="btn btn-sm btn-default <%= display? "" : "active" %>">Hide</button>
</div>
</div>
<div class="setting clearfix">
<div>Light Version</div>
<div>
    <a href="../light/index.html" class="btn btn-sm btn-default">&nbsp; Switch &nbsp;   <i class="fa fa-angle-right"></i></a>
</div>
</div>
<div class="setting clearfix">
<div>White Version</div>
<div>
    <a href="../white/index.html" class="btn btn-sm btn-default">&nbsp; Switch &nbsp;   <i class="fa fa-angle-right"></i></a>
</div>
</div>
</script>

<script type="text/template" id="sidebar-settings-template">
<% auto = sidebarState == "auto"%>
<% if (auto) {%>
<button type="button"
    data-value="icons"
    class="btn-icons btn btn-transparent btn-sm">Icons</button>
<button type="button"
    data-value="auto"
    class="btn-auto btn btn-transparent btn-sm">Auto</button>
<%} else {%>
<button type="button"
    data-value="auto"
    class="btn btn-transparent btn-sm">Auto</button>
<% } %>
</script>

<!-- page specific scripts -->
<!-- page specific libs -->
<script src="lib/moment/min/moment.min.js"></script>
<script src="lib/jquery-ui/ui/core.js"></script>
<script src="lib/jquery-ui/ui/widget.js"></script>
<script src="lib/jquery-ui/ui/mouse.js"></script>
<script src="lib/jquery-ui/ui/draggable.js"></script>
<script src="lib/fullcalendar/dist/fullcalendar.min.js"></script>
<!-- page application js -->
<script src="js/component-calendar.js"></script>


';
?>
